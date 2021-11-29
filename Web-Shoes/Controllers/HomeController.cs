using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Entity;
using Web_Fashion.Models;
using Web_Fashion.StatisFile;

namespace Web_Fashion.Controllers
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
            // Review-Home 
            var CustomerHomeQuery = from a in _context.CustomerHomes select a;

            foreach (var item in CustomerHomeQuery)
            {
                switch (item.CustomerHomeName)
                {
                    case "FeatureHome1":
                        // code block
                        ViewBag.CustomerName1 = item.CustomerHomeName;
                        ViewBag.CustomerStar1 = item.CustomerHome_CStar;
                        ViewBag.CustomerImg1 = item.CustomerHome_CImg;
                        ViewBag.CustomerDesription1 = item.CustomerHome_CDesription;
                        ViewBag.CustomerWork1 = item.CustomerHome_CWork;
                        break;
                    case "FeatureHome2":
                        // code block
                        ViewBag.CustomerName2 = item.CustomerHomeName;
                        ViewBag.CustomerStar2 = item.CustomerHome_CStar;
                        ViewBag.CustomerImg2 = item.CustomerHome_CImg;
                        ViewBag.CustomerDesription2 = item.CustomerHome_CDesription;
                        ViewBag.CustomerWork2 = item.CustomerHome_CWork;
                        break;
                    case "FeatureHome3":
                        // code block
                        ViewBag.CustomerName3 = item.CustomerHomeName;
                        ViewBag.CustomerStar3 = item.CustomerHome_CStar;
                        ViewBag.CustomerImg3 = item.CustomerHome_CImg;
                        ViewBag.CustomerDesription3 = item.CustomerHome_CDesription;
                        ViewBag.CustomerWork3 = item.CustomerHome_CWork;
                        break;
                    default:
                        break;
                }
            }


            //Feature-Home
            var FeatureHomeQuery = _context.FeatureHomes.FirstOrDefault(a => a.FeatureHomeName == "FeatureHome1");
            ViewBag.FeatureTitle1 = FeatureHomeQuery.FeatureHomeTitle1;
            ViewBag.FeatureDesription1 = FeatureHomeQuery.FeatureHomeDesription1;
            ViewBag.FeatureTitle2 = FeatureHomeQuery.FeatureHomeTitle2;
            ViewBag.FeatureDesription2 = FeatureHomeQuery.FeatureHomeDesription2;
            ViewBag.FeatureTitle3 = FeatureHomeQuery.FeatureHomeTitle3;
            ViewBag.FeatureDesription3 = FeatureHomeQuery.FeatureHomeDesription3;
            ViewBag.FeatureTitle4 = FeatureHomeQuery.FeatureHomeTitle4;
            ViewBag.FeatureDesription4 = FeatureHomeQuery.FeatureHomeDesription4;



            //Slider-Home
            var SliderHomeQuery = _context.SliderHomes.FirstOrDefault(a => a.SliderName == "SliderHome1");
            ViewBag.SliderHome1 = SliderHomeQuery.SliderUrl1;
            ViewBag.SliderHome2 = SliderHomeQuery.SliderUrl2;
            ViewBag.SliderHome3 = SliderHomeQuery.SliderUrl3;
            ViewBag.SliderHome4 = SliderHomeQuery.SliderUrl4;
            ViewBag.SliderHome5 = SliderHomeQuery.SliderUrl5;


            //Categories-Home
            var CategoriesHomeQuery = _context.CategoriesHomes.FirstOrDefault(a => a.CategoriesHomeName == "CategoriesHome1");
            ViewBag.CategoriesHome1 = CategoriesHomeQuery.CategoriesHomeUrl1;
            ViewBag.CategoriesHome2 = CategoriesHomeQuery.CategoriesHomeUrl2;
            ViewBag.CategoriesHome3 = CategoriesHomeQuery.CategoriesHomeUrl3;
            ViewBag.CategoriesHome4 = CategoriesHomeQuery.CategoriesHomeUrl4;
            ViewBag.CategoriesHome5 = CategoriesHomeQuery.CategoriesHomeUrl5;
            ViewBag.CategoriesHome6 = CategoriesHomeQuery.CategoriesHomeUrl6;
            ViewBag.CategoriesHome7 = CategoriesHomeQuery.CategoriesHomeUrl7;
            ViewBag.CategoriesHome8 = CategoriesHomeQuery.CategoriesHomeUrl8;



            // Process Of Home
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

        [Route("/Home/SubsriberAsync")]
        [HttpGet]
        public async Task<IActionResult> SubsriberAsync(string Subsriber)
        {

            var addSubsriber = new Subscribers()
            {
                Subs_Id = Guid.NewGuid().ToString(),
                Subs_Mail = Subsriber,
                Subs_TimeUpdate = DateTime.Now
            };

            _context.Subscribers.Add(addSubsriber);

            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        
    }
}
