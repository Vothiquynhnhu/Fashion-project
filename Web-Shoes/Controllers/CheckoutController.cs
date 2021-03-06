using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Entity;
using Web_Fashion.Models;
using Web_Fashion.StatisFile;

namespace Web_Fashion.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;

        private  string userId;
        private string checkLogin;
        private string deviceIdSession;
        private readonly ISendMailService _sendMailService;

        public CheckoutController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager, ISendMailService sendMailService)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
            _sendMailService = sendMailService;

        }


        [Route("/checkout")]
        [HttpGet("{reduceprice}")]
        public IActionResult Index()
        {
            try
            {
                userId = HttpContext.Session.GetString(KeySession.userIdSession);
                checkLogin = HttpContext.Session.GetString(KeySession.CheckLoginSession);
                string namePc = HttpContext.Session.GetString(KeySession.CheckLoginSession); 
                deviceIdSession = HttpContext.Session.GetString(KeySession.deviceIdSession);

                //Print Value for form

                // query to form 

                var queryForm = _context.AppUser.FirstOrDefault(a => a.Id == userId);

                // Create viewbag
                ViewBag.FirstName = queryForm.FirstName;
                ViewBag.LastName = queryForm.LastName;
                ViewBag.Email = queryForm.Email;
                ViewBag.Phone = queryForm.PhoneNumber;
                ViewBag.Address1 = queryForm.bill_Address1;
                ViewBag.Country = queryForm.bill_Country;
                ViewBag.City = queryForm.bill_Country; ;
                ViewBag.State = queryForm.bill_City;
                ViewBag.Postal = queryForm.bill_PostalCode;








                // Proccess CheckOut
                var userName = User.FindFirstValue(ClaimTypes.Name);

                if (checkLogin == "True")
                {
                    //login
                    var query = from a in _context.Products
                                join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                                join c in _context.Cart on b.pic_CartId equals c.cart_Id
                                join d in _context.AppUser on c.cart_UserID equals d.Id
                                select new { a, b, c, d };


                    query = query.Where(x => x.d.Id == userId);


                    // Check Discount
                    var querydiscount = _context.Cart.FirstOrDefault(a => a.cart_UserID == userId);
                    ViewBag.Discount = querydiscount.cart_Discount;

                    var productInCartModelQuery = query
                        .Select(x => new ProductInCartModel()
                        {
                            ProductId = x.a.pd_Id,
                            ProductName = x.a.pd_Name,
                            ProductPrice = x.a.pd_Price,
                            ProductImg1 = x.a.pd_Img1,
                            Quantity = x.b.pic_amount,
                            UserId = x.d.Id,
                            Color = x.b.pic_color,
                            Size = x.b.pic_size

                        });


                    var cartDetail = query.Select(a => new CheckOutModel()
                    {
                        checkout_ProductName = a.a.pd_Name,
                        checkout_Quantity = a.b.pic_amount,
                        checkout_Price = a.a.pd_Price
                    });

                    var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");

                    int reTotal = 0;
                    foreach (var item in cartDetail)
                    {
                        reTotal += item.checkout_Price;
                    }

                    ViewBag.Retotal = reTotal;
                    ViewBag.Ship = 0;
                    int ship = 0;

                    if (shipingQuery != null)
                    {

                        string a = shipingQuery.ship_Price.ToString();
                        ship = Int32.Parse(a);
                        ViewBag.Ship = ship;
                    }

                    
                    ViewBag.Total = reTotal + ship - querydiscount.cart_Discount;
                    return View(cartDetail);
                }
                else
                {
                    //Not login

                    return View();
                }


                
            }
            catch 
            {

                return View();
            }



            


        }

        [Route("/checkoutAdd")]
        [HttpGet("{reduceprice}")]
        public async Task<IActionResult> AddToBill()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);
            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

            string firstName = Request.Query["FirstName"];
            string country = Request.Query["Country"];
            string lastName = Request.Query["LastName"];
            string address1 = Request.Query["Address1"];
            string city = Request.Query["City"];
            string state = Request.Query["State"];
            string postal = Request.Query["Postal"];
            string email = Request.Query["Email"];
            string phone = Request.Query["Phone"];
            

            if (checkLogin)
            {
                var query = from a in _context.Products
                            join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId // saved product after user choses
                            join c in _context.Cart on b.pic_CartId equals c.cart_Id
                            join d in _context.AppUser on c.cart_UserID equals d.Id
                            select new { a, b, c, d };
                query = query.Where(x => x.d.Id == userId);


                // Get Information of product
                var productInCartModelQuery = query
                    .Select(x => new ProductInCartModel()
                    {
                        ProductId = x.a.pd_Id,
                        ProductName = x.a.pd_Name,
                        ProductPrice = x.a.pd_Price,
                        ProductImg1 = x.a.pd_Img1,
                        Quantity = x.b.pic_amount,
                        UserId = x.d.Id,
                        Color = x.b.pic_color,
                        Size = x.b.pic_size
                    });



                // List products were chose
                var cartDetail = query.Select(a => new CheckOutModel()
                {
                    checkout_ProductName = a.a.pd_Name,
                    checkout_Quantity = a.b.pic_amount,
                    checkout_Price = a.a.pd_Price,
                    checkout_ProductColor = a.b.pic_color,
                    checkout_Productize = a.b.pic_size,
                    checkout_ProductId = a.b.pic_ProductId
                });

                


                int reTotal = 0;
                foreach (var item in cartDetail)
                {
                    reTotal += item.checkout_Price * item.checkout_Quantity;
                }


                // Query Price of ship
                var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");
                int ship = 0;

                if (shipingQuery != null)
                {
                    string a = shipingQuery.ship_Price.ToString();
                    ship = Int32.Parse(a);
                    ViewBag.Ship = ship;
                }



                //print in Bill
                string productNameList = "";
                string productColorList = "";
                string productSizeList = "";
                string productQuatityList = "";
                string productPriceList = "";
                string productIdList = "";
                foreach (var item in cartDetail)
                {
                    productNameList +=  item.checkout_ProductName + "|" ;
                    productColorList += item.checkout_ProductColor + "|";
                    productSizeList += item.checkout_Productize + "|";
                    productQuatityList += item.checkout_Quantity + "|";
                    productPriceList += item.checkout_Price*item.checkout_Quantity + "|";
                    productIdList += item.checkout_ProductId + "|";
                }

                //Check discount
                var queryDiscount = _context.Cart.FirstOrDefault(a => a.cart_UserID == userId);
                string billId = Guid.NewGuid().ToString();
                var bill = new Bills()
                {
                    bill_Id = billId,
                    bill_UserId = userId,
                    bill_ProductIdlist = productIdList,
                    bill_Discount = queryDiscount.cart_Discount,
                    bill_Shipping = ship,
                    bill_PaidTotal = reTotal + ship - queryDiscount.cart_Discount,
                    bill_ProductNamelist = productNameList,
                    bill_ProductColorlist = productColorList,
                    bill_ProductSizelist = productSizeList,
                    bill_Quantity = productQuatityList,
                    bill_ProductPricelist = productPriceList,
                    bill_PaymentMethod = "Check Payment"


                };

                // Form -----------------------------------------------------------------------------------
                // Save Form
                // query to form 
                var queryForm = _context.AppUser.FirstOrDefault(a => a.Id == userId);

                queryForm.FirstName = firstName;
                queryForm.LastName = lastName;
                queryForm.Email = email;
                queryForm.PhoneNumber = phone;
                queryForm.bill_Address1 = address1;
                queryForm.bill_Country = country;
                queryForm.bill_City = city;
                queryForm.bill_PostalCode = postal;

                // SendMail -----------------------------------------------------------------------------------
                //Confirm Mail
                string IdOrder = billId;
                string MailTo = email;
                string Subject = "Order Confirm #"+ billId;
                string NameUser = firstName;
                string Phone = phone;
                string Address = address1;
                string Email = email;
                int Price = reTotal;


                //"+ Price + "
                string productList = "";
                foreach (var item in cartDetail)
                {
                    productList += "<tr><td>" + item.checkout_ProductName + "</td><td>" + item.checkout_Price + "</td><td>" + item.checkout_ProductColor + "</td><td>" + item.checkout_Quantity + "</td><td>" + item.checkout_Price + "</td></tr>";
                }


                string contentOfProductList = "<div><table cellpadding=\"0\" cellspacing=\"0\" width=\"700\" align=\"left\" border=\"1\" ><thead><tr><th> Name </th><th> Size </th><th> Color </th><th> Amount </th><th> Price </th></tr></thead><tbody> " +
                    productList +
                    "<tr><td colspan=\"3\"></td><td>Ship:</td><td>1$</td></tr><tr>" +
                    "<td colspan=\"3\"></td><td>Discount:</td><td>5$</td></tr><tr>" +
                    "<td colspan=\"3\"></td><td>Sum Price:</td><td>2000$</td></tr>" +
                    "</tbody></table></div>";

                MailContent content = new MailContent
                {
                    To = MailTo,
                    Subject = Subject,
                    Body = "<div><div><center> <h2> Order confirmation " + IdOrder + "</h2> </center></div>" +
                    "<div><table class='table'><tr><th>:</th>" +
                    "<td>" + NameUser + "</td></tr><tr><th>Phone:</th><td>" + Phone + "</td></tr><tr><th>Address:</th><td>" + Address + "</td></tr><tr><th>Email:</th>" +
                    "<td>" + Email + "</td></tr><tr><th>Price:</th><td>" + Price + "$ </td></tr></table></div>" +
                     "<br />"+contentOfProductList +
                    "</div>"
                };

                await _sendMailService.SendMail(content);

                // Check Add information
                var queryUser = _context.AppUser.FirstOrDefault(a => a.Id == userId);

                queryUser.FirstName = firstName;
                queryUser.LastName = lastName;
                queryUser.Email = email;
                queryUser.bill_Country = country;
                queryUser.bill_Address1 = address1;
                queryUser.bill_City = city;
                queryUser.bill_PostalCode = postal;
                queryUser.bill_State = state;
                queryUser.PhoneNumber = phone;



                /// Add
                _context.Bills.Add(bill);

                /// Remove
                var CartQuery = _context.Cart.FirstOrDefault(x => x.cart_UserID == userId);

                if (CartQuery != null)
                {
                    var ProductInCartQueryDelete = _context.ProductInCart.Where(a => a.pic_CartId == CartQuery.cart_Id);

                    _context.ProductInCart.RemoveRange(ProductInCartQueryDelete);
                }


                await _context.SaveChangesAsync();
            }
            else
            {

            }
            



            return Redirect("/OrderComplete");
        }



    }
}
