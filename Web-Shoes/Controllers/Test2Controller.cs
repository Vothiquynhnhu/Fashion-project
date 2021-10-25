using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Controllers
{
    public class Test2Controller : Controller
    {
        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";


        [Route("/test2")]
        [HttpGet]
        public IActionResult Index()
        {

            //// Requires: using Microsoft.AspNetCore.Http;
            //if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
            //{
                
            //}

            var name = HttpContext.Session.GetString(SessionKeyName);
            var age = HttpContext.Session.GetInt32(SessionKeyAge);

            ViewBag.test = name.ToString();
            return View();
        }
    }
}
