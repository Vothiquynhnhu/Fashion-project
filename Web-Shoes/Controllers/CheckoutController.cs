using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Function;
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
        public IActionResult Index(string reduceprice = "0")
        {
            try
            {
                string namePc = Environment.MachineName;
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var userName = User.FindFirstValue(ClaimTypes.Name);


                if (checkLogin)
                {
                    var query = from a in _context.Products
                                join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                                join c in _context.Cart on b.pic_CartId equals c.cart_Id
                                join d in _context.AppUser on c.cart_UserID equals d.Id
                                select new { a, b, c, d };

                    query = query.Where(x => x.d.Id == userId);

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



                    ViewBag.Discount = reduceprice;

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



                    int discount = Int32.Parse(reduceprice);
                    ViewBag.Total = reTotal + ship - discount;

                    return View(cartDetail);
                }
                else
                {
                    var query = from a in _context.Products
                                join b in _context.ProductInCartDevices on a.pd_Id equals b.picd_ProductId
                                join c in _context.CartsDevice on b.picd_CartId equals c.cartd_Id
                                join d in _context.Devices on c.cartd_DeviceId equals d.deviceId
                                select new { a, b, c, d };

                    query = query.Where(x => x.d.deviceName == namePc);

                    var productInCartModelQuery = query
                        .Select(x => new ProductInCartModel()
                        {
                            ProductId = x.a.pd_Id,
                            ProductName = x.a.pd_Name,
                            ProductPrice = x.a.pd_Price,
                            ProductImg1 = x.a.pd_Img1,
                            Quantity = x.b.picd_amount,
                            UserId = x.d.deviceId,
                            Color = x.b.picd_color,
                            Size = x.b.picd_size

                        });


                    var cartDetail = query.Select(a => new CheckOutModel()
                    {
                        checkout_ProductName = a.a.pd_Name,
                        checkout_Quantity = a.b.picd_amount,
                        checkout_Price = a.a.pd_Price
                    });

                    var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");



                    ViewBag.Discount = reduceprice;

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



                    int discount = Int32.Parse(reduceprice);
                    ViewBag.Total = reTotal + ship - discount;

                    return View(cartDetail);
                }
            }
            catch 
            {

                return View();
            }



            


        }

        [Route("/checkoutAdd")]
        [HttpGet("{reduceprice}")]
        public async Task<IActionResult> AddToBill(String reduceprice ="0")
        {



            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var userName = User.FindFirstValue(ClaimTypes.Name);

            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();



            string firstName = Request.Query["FirstName"];
            string country = Request.Query["Country"];
            string lastName = Request.Query["LastName"];
            string companyName = Request.Query["CompanyName"];
            string address1 = Request.Query["Address1"];
            string address2 = Request.Query["Address2"];
            string city = Request.Query["City"];
            string state = Request.Query["State"];
            string postal = Request.Query["Postal"];
            string email = Request.Query["Email"];
            string phone = Request.Query["Phone"];


            
            

            string titleMail = "Order confirmation successful";
            string descriptionMail = email + " have placed an order OR1";

            if (checkLogin)
            {

                var queryCartPrice = _context.Cart.FirstOrDefault(a => a.cart_UserID == userId);

                int reducePrice = queryCartPrice.cart_Discount;


                var query = from a in _context.Products
                            join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                            join c in _context.Cart on b.pic_CartId equals c.cart_Id
                            join d in _context.AppUser on c.cart_UserID equals d.Id
                            select new { a, b, c, d };


                query = query.Where(x => x.d.Id == userId);



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
                    checkout_Price = a.a.pd_Price,
                    checkout_Color = a.b.pic_color,
                    checkout_Size = a.b.pic_size,
                    checkout_ProductId = a.b.pic_ProductId
                });

                var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");



                ViewBag.Discount = reducePrice;

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

                int discount = reducePrice;
                ViewBag.Total = reTotal + ship - discount;

                //Array Name product
                //Array Id product
                //Array Size product
                //Array Color  product
                //Array Price product
                string productNameList = "";
                string productQuantityList = "";
                string productIdList = "";
                string productSizeList = "";
                string productColorList = "";
                string productPriceList = "";

                foreach (var item in cartDetail)
                {
                    productNameList += "|" + item.checkout_ProductName;
                    productQuantityList += "|" + item.checkout_Quantity;
                    productIdList += "|" + item.checkout_ProductId;
                    productSizeList += "|" + item.checkout_Size;
                    productColorList += "|" + item.checkout_Color;
                    productPriceList += "|" + item.checkout_Price;

                }

                var bill = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
                    bill_UserId = userId,
                    bill_Discount = discount,
                    bill_Shipping = ship,
                    bill_PaidTotal = reTotal + ship - discount,
                    bill_ProductNamelist = productNameList,
                    bill_ProductIdlist = productIdList,
                    bill_ProductSizelist = productSizeList,
                    bill_ProductColorlist = productColorList,
                    bill_ProductPricelist = productPriceList


                };

                /// Add
                var resultBill = _context.Bills.Add(bill);



                //Send Mail-

                if (resultBill != null)
                {
                    SendMail sendMail = new SendMail(email, titleMail, descriptionMail);
                    sendMail.Send();
                }


                /// Remove-------------------------------------------------------------------------------------
                var CartQuery = _context.Cart.FirstOrDefault(x => x.cart_UserID == userId);
                var ProductInCartQueryDelete = _context.ProductInCart.Where(a => a.pic_CartId == CartQuery.cart_Id);
                _context.ProductInCart.RemoveRange(ProductInCartQueryDelete);
                CartQuery.cart_Discount = 0;
                await _context.SaveChangesAsync();
            }
            else
            {
                var queryDevice = _context.Devices.FirstOrDefault(a=>a.deviceName == namePc);
                var queryCartPrice = _context.CartsDevice.FirstOrDefault(a => a.cartd_DeviceId == queryDevice.deviceId);
                int reducePrice = queryCartPrice.cartd_Discount;


                var query = from a in _context.Products
                            join b in _context.ProductInCartDevices on a.pd_Id equals b.picd_ProductId
                            join c in _context.CartsDevice on b.picd_CartId equals c.cartd_Id
                            join d in _context.Devices on c.cartd_DeviceId equals d.deviceId
                            select new { a, b, c, d };


                query = query.Where(x => x.d.deviceName == namePc);

                var productInCartModelQuery = query
                    .Select(x => new ProductInCartModel()
                    {
                        ProductId = x.a.pd_Id,
                        ProductName = x.a.pd_Name,
                        ProductPrice = x.a.pd_Price,
                        ProductImg1 = x.a.pd_Img1,
                        Quantity = x.b.picd_amount,
                        UserId = x.d.deviceId,
                        Color = x.b.picd_color,
                        Size = x.b.picd_size

                    });


                var cartDetail = query.Select(a => new CheckOutModel()
                {
                    checkout_ProductName = a.a.pd_Name,
                    checkout_Quantity = a.b.picd_amount,
                    checkout_Price = a.a.pd_Price,
                    checkout_Size = a.b.picd_size,
                    checkout_Color = a.b.picd_color,
                    checkout_ProductId = a.b.picd_ProductId

                });

                var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");



                ViewBag.Discount = reducePrice;

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



                int discount = reducePrice;
                ViewBag.Total = reTotal + ship - discount;

                //Array Name product
                //Array Id product
                //Array Size product
                //Array Color  product
                //Array Price product
                string productNameList = "";
                string productQuantityList = "";
                string productIdList = "";
                string productSizeList = "";
                string productColorList = "";
                string productPriceList = "";
                foreach (var item in cartDetail)
                {
                    productNameList += "|" + item.checkout_ProductName;
                    productQuantityList += "|" + item.checkout_Quantity;
                    productIdList += "|" + item.checkout_ProductId;
                    productSizeList += "|" + item.checkout_Size;
                    productColorList += "|" + item.checkout_Color;
                    productPriceList += "|" + item.checkout_Price;
                }





                //create UserId
                var queryUserInDevice = from a in _context.Devices
                                        join b in _context.UserInDevices on a.deviceId equals b.UiD_DeviceId
                                        join c in _context.AppUser on b.UiD_UserId equals c.Id
                                        select new { a, b, c, };

                var findUserExistInDevice = queryUserInDevice.Where(x => x.a.deviceName  == namePc);
                var userIdNew = Guid.NewGuid().ToString();

                if (findUserExistInDevice.Count() == 0)
                {
                    

                    var user = new AppUser { Id = userIdNew, UserName = namePc, Email = email };
                    var createUser = await _UserManager.CreateAsync(user, "123456Aa@");

                    var userInDevice = new UserInDevice()
                    {
                        UiD_UserId = userIdNew,
                        UiD_DeviceId = queryDevice.deviceId
                    };


                }
                else
                {
                    foreach (var item in findUserExistInDevice)
                    {
                        userIdNew = item.c.Id;
                    }
                }

                var bill = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
                    bill_UserId = userIdNew,
                    bill_Discount = discount,
                    bill_Shipping = ship,
                    bill_PaidTotal = reTotal + ship - discount,
                    bill_ProductNamelist = productNameList,
                    bill_ProductIdlist = productIdList,
                    bill_ProductSizelist = productSizeList,
                    bill_ProductColorlist = productColorList,
                    bill_ProductPricelist = productPriceList


                };

                /// Add
                var resultBill = _context.Bills.Add(bill);


                //Send Mail-----------------------------------------------------------------

                if (resultBill != null)
                {
                    SendMail sendMail = new SendMail(email, titleMail, descriptionMail);
                    sendMail.Send();
                }



                

                /// Remove---------------------------------------------------------------------
                var CartQuery = _context.CartsDevice.FirstOrDefault(x => x.cartd_DeviceId == queryDevice.deviceId);
                var ProductInCartQueryDelete = _context.ProductInCartDevices.Where(a => a.picd_CartId == CartQuery.cartd_Id);
                _context.ProductInCartDevices.RemoveRange(ProductInCartQueryDelete);
                CartQuery.cartd_Discount = 0;

                await _context.SaveChangesAsync();
                

            }
            return Redirect("/OrderComplete");
        }



    }
}
