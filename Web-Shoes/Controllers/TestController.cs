
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class TestController : Controller
    {

        private readonly ApplicationDbContext _context;

        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";

        public TestController(ApplicationDbContext context)
        {
            _context = context;

        }


        [Route("/test")]
        [HttpGet]
        public IActionResult Index()
        {


            // Requires: using Microsoft.AspNetCore.Http;
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
            {
                HttpContext.Session.SetString(SessionKeyName, "The Doctor");
                HttpContext.Session.SetInt32(SessionKeyAge, 773);
            }

            var name = HttpContext.Session.GetString(SessionKeyName);
            var age = HttpContext.Session.GetInt32(SessionKeyAge);



            ViewBag.test = name.ToString();

            return View();
        }



    }
}
