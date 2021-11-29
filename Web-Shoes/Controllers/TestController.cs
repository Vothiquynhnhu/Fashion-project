
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;

namespace Web_Shoes.Controllers
{
    public class TestController : Controller
    {

        private readonly ApplicationDbContext _context;


        private readonly ISendMailService _sendMailService;
        public TestController(ApplicationDbContext context, ISendMailService sendMailService)
        {
            _context = context;
            _sendMailService = sendMailService;
        }


        //[Route("/test")]
        //[HttpGet]
        //public IActionResult Index()
        //{

        //    return View();
        //}


        [Route("/test")]
        [HttpGet]
        public IActionResult Index()
        {
            

            return View();
        }



    }


    

}


