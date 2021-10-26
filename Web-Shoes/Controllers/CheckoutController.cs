using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;

        public CheckoutController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
        }


        [Route("/checkout")]
        [HttpGet("{reduceprice}")]
        public IActionResult Index()
        {
            try
            {
                string namePc = Environment.MachineName;
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);

                if (checkLogin)
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
                var bill = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
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
