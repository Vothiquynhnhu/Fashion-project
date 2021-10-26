using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;
using Web_Shoes.StatisFile;

namespace Web_Shoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        int countCart = 0;
        string cartId = "";
        string deviceIdHome = "";

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);
            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

            //Check and create pc
            CreateDevice(namePc);

            
            CreateSessionAll(checkLogin, userId, deviceIdHome, userName);

            ViewBag.cartCount = countCart;

            var HomeProductQuery = from a in _context.Products select a;

            return View(HomeProductQuery);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public void CreateSessionAll(bool login, string userid, string PcId, string userName)
        {
            CreateSessionCart(login, userid, PcId);
            CreateSessionUser(login, userid, userName);

        }

        public void CreateDevice( string PcName)
        {
            try
            {
                var queryDevice = _context.Devices.FirstOrDefault(a => a.deviceName == PcName);

                 deviceIdHome = Guid.NewGuid().ToString();

                if (queryDevice == null)
                {
                    var createDivice = new Device()
                    {
                        deviceId = deviceIdHome,
                        deviceName = PcName
                    };

                    _context.Devices.Add(createDivice);

                    _context.SaveChanges();

                    HttpContext.Session.SetString(KeySession.deviceIdSession, deviceIdHome);
                }
                else
                {
                    deviceIdHome = queryDevice.deviceId;

                    HttpContext.Session.SetString(KeySession.deviceIdSession, deviceIdHome);
                }

                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void CreateSessionCart(bool login, string userid, string PcId)
        {
            
                

                cartId = Guid.NewGuid().ToString();

                //Create cart /////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (login)
                {
                    //Logined
                    try
                    {
                        
                        //Check cart exist 
                        var queryCartExist = _context.Cart.FirstOrDefault(a => a.cart_UserID == userid);

                        if (queryCartExist == null)
                        {
                            //Create cart
                            var cartCreate = new Cart()
                            {
                                cart_Id = cartId,
                                cart_UserID = userid
                            };

                            _context.Cart.Add(cartCreate);
                        }
                        else
                        {
                            cartId = queryCartExist.cart_Id;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    try
                    {
                        //Check cart exist 
                        var queryCartExist = _context.CartsDevice.FirstOrDefault(a => a.cartd_DeviceId == PcId);

                        if (queryCartExist == null)
                        {
                            //Create cart
                            var cartCreate = new CartsDevice()
                            {
                                cartd_Id = cartId,
                                cartd_DeviceId = PcId
                            };

                            _context.CartsDevice.Add(cartCreate);
                        }
                        else
                        {
                            cartId = queryCartExist.cartd_Id;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            _context.SaveChanges();


                // check cart /////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (login)
                {
                    var querycart = from a in _context.Cart
                                    join b in _context.ProductInCart on a.cart_Id equals b.pic_CartId
                                    select new { a, b };
                    querycart = querycart.Where(a => a.a.cart_UserID == userid);

                    countCart = querycart.Count();

                }
                else
                {
                    var querycart = from a in _context.CartsDevice
                                    join b in _context.ProductInCartDevices on a.cartd_Id equals b.picd_CartId
                                    select new { a, b };

                    querycart = querycart.Where(a => a.a.cartd_DeviceId == PcId);

                    try
                    {
                        countCart = querycart.Count();
                    }
                    catch
                    {

                        countCart = 0;
                    }
                }

                //Set Session
                HttpContext.Session.SetString(KeySession.cartHomeSession, countCart.ToString());





                // CartI Id /////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Set session

                if (login)
                {
                    var queryCart = _context.Cart.FirstOrDefault(a => a.cart_UserID == userid);


                    //Set Session
                    HttpContext.Session.SetString(KeySession.cartIdSession, queryCart.cart_Id.ToString());

                }
                else
                {

                    var queryCart = _context.CartsDevice.FirstOrDefault(a => a.cartd_DeviceId == PcId);


                    //Set Session
                    HttpContext.Session.SetString(KeySession.cartIdSession, queryCart.cartd_Id.ToString());

                }
            

        }

        public void CreateSessionUser(bool login, string userid, string userName)
        {
            //Status Login
            //Set Session
            HttpContext.Session.SetString(KeySession.CheckLoginSession, login.ToString());

            if (userid != null && userName != null)
            {
                //User Id
                //Set Session
                HttpContext.Session.SetString(KeySession.userIdSession, userid.ToString());

                //User Name
                //Set Session
                HttpContext.Session.SetString(KeySession.userNameSession, userName.ToString());
            }
            


            


        }

        
    }
}
