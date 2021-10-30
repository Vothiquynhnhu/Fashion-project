using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class SearchController : Controller
    {

        private readonly ApplicationDbContext _context;


        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SearchController
        public ActionResult Index()
        {
            return View();
        }


    }
}
