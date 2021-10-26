using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.StatisFile;

namespace Web_Shoes.Controllers
{
    public class Test2Controller : Controller
    {
        [Route("/test2")]
        [HttpGet]
        public IActionResult Index()
        {

            


            var cartId = HttpContext.Session.GetString(KeySession.cartIdSession);
            var cartHome = HttpContext.Session.GetInt32(KeySession.cartHomeSession);
            var userId = HttpContext.Session.GetString(KeySession.userIdSession);
            var userName = HttpContext.Session.GetInt32(KeySession.userNameSession);
            var deviceId = HttpContext.Session.GetString(KeySession.deviceIdSession);
            

            ViewBag.cartId = cartId.ToString();
            ViewBag.cartHome = cartHome.ToString();
            
            ViewBag.deviceId = deviceId.ToString();
            if (userId != null)
            {
                ViewBag.userId = userId.ToString();
                ViewBag.userName = userName.ToString();
            }
            
            return View();
        }
    }
}
