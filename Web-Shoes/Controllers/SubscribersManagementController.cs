using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Entity;
using Web_Fashion.Models;

namespace Web_Fashion.Controllers
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
