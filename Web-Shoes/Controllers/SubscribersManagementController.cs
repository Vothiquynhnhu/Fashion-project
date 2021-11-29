using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SubscribersManagementController : Controller
    {

        private readonly ApplicationDbContext _context;


        public SubscribersManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/subsribersmanagement")]
        [HttpGet]
        public IActionResult Index()
        {

            try
            {
                var subsriber = from a in _context.Subscribers select a;

                return View(subsriber);
            }
            catch 
            {

                throw;
            }
            
        }
    }
}
