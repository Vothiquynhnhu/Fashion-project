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
    public class CartController : Controller
    {


        private readonly ApplicationDbContext _context;

        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;

        public CartController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
        }


        [Route("/cart")]
        [HttpGet("{productid}&{quantity}")]
        public IActionResult Index(int productid, int quantity)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);

            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();


            if (checkLogin)
            {
                //login
                //Check Discount 
                var queryCart = _context.Cart.FirstOrDefault(a => a.cart_UserID == userId);
                if (queryCart.cart_Discount != 0 || queryCart != null)
                {
                    ViewBag.Discount = queryCart.cart_Discount;
                }
                else
                {
                    ViewBag.Discount = 0;
                }


                //Query multiple cart
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

                return View(productInCartModelQuery);
            }
            else
            {
                //No login
                //Get id of device
                var queryDevice = _context.Devices.FirstOrDefault(a => a.deviceName == namePc);

                
                //Check Discount 
                var queryCart = _context.CartsDevice.FirstOrDefault(a => a.cartd_DeviceId == queryDevice.deviceId);
                if (queryCart.cartd_Discount != 0 || queryCart != null)
                {
                    ViewBag.Discount = queryCart.cartd_Discount;
                }
                else
                {
                    ViewBag.Discount = 0;
                }



                //Query multiple cart
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

                return View(productInCartModelQuery);

            }






        }



        [Route("/cart/remove")]
        [HttpGet("{productid}&{quantity}")]
        public IActionResult RemoveProduct(int productid, int quantity)
        {



            try
            {

                string namePc = Environment.MachineName;
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault(); 

                 var xem = User.FindFirstValue(ClaimTypes.Email);

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);

                if (checkLogin)
                {
                    var productQuery = _context.ProductInCart.FirstOrDefault(a => a.pic_ProductId == productid);
                    _context.ProductInCart.Remove(productQuery);
                    _context.SaveChanges();
                }
                else
                {
                    var productQuery = _context.ProductInCartDevices.FirstOrDefault(a => a.picd_ProductId == productid);
                    _context.ProductInCartDevices.Remove(productQuery);
                    _context.SaveChanges();
                }



                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }

            ////

        }

        [Route("/cart/paid")]
        [HttpGet("{coupon}&{quantity}")]
        public IActionResult addpaid(string coupon, int quantity)
        {

            try
            {

                coupon = "hihi";
                int ReducePrice = 0;

                var couponQuery = _context.Coupons.FirstOrDefault(a => a.couponCode == coupon);

                if (couponQuery != null)
                {
                    ReducePrice = couponQuery.couponPrice;
                }




                return Redirect("/checkout?reduceprice=" + ReducePrice);
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }

        }

        [Route("/coupon")]
        [HttpGet]
        public IActionResult AddCoupon()
        {

            try
            {
                string namePc = Environment.MachineName;
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);
                string codeCoupon = Request.Query["codecoupon"];

                if (checkLogin)
                {
                    //Logined
                    //Check Coupon

                    var queryCoupon = _context.Coupons.FirstOrDefault(a => a.couponCode == codeCoupon);
                    var queryCartUser = _context.Cart.FirstOrDefault(a => a.cart_UserID == userId);
                    if (queryCoupon != null)
                    {
                        
                        queryCartUser.cart_Discount = queryCoupon.couponPrice;
                        
                    }
                    else
                    {
                        queryCartUser.cart_Discount = 0;
                    }
                    _context.SaveChanges();

                }
                else
                {
                    //Not login
                    //Get id divice
                    var queryDevice = _context.Devices.FirstOrDefault(a => a.deviceName == namePc);

                    //Check Coupon
                    var queryCoupon = _context.Coupons.FirstOrDefault(a => a.couponCode == codeCoupon);

                    var queryCartDevice = _context.CartsDevice.FirstOrDefault(a => a.cartd_DeviceId == queryDevice.deviceId);
                    if (queryCoupon != null)
                    {
                        
                        queryCartDevice.cartd_Discount = queryCoupon.couponPrice;
                        
                    }
                    else
                    {
                        queryCartDevice.cartd_Discount = 0;
                    }
                    _context.SaveChanges();

                }

                
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }
    }
}
