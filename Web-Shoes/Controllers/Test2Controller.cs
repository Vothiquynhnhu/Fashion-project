using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Entity;
using Web_Fashion.Service;
using Web_Fashion.StatisFile;

namespace Web_Fashion.Controllers
{
    public class Test2Controller : Controller
    {

        private readonly ApplicationDbContext _context;


        private readonly ISendMailService _sendMailService;
        public Test2Controller(ApplicationDbContext context, ISendMailService sendMailService)
        {
            _context = context;
            _sendMailService = sendMailService;
        }

        [Route("/test2")]
        [HttpGet]
        //    public async Task<IActionResult> Index(
        //string sortOrder,
        //string currentFilter,
        //string searchString,
        //int? pageNumber)
        //    {
        //        ViewData["CurrentSort"] = sortOrder;
        //        ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        //        ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

        //        if (searchString != null)
        //        {
        //            pageNumber = 1;
        //        }
        //        else
        //        {
        //            searchString = currentFilter;
        //        }

        //        ViewData["CurrentFilter"] = searchString;

        //        var students = from s in _context.Products
        //                       select s;
        //        if (!String.IsNullOrEmpty(searchString))
        //        {
        //            students = students.Where(s => s.pd_Name.Contains(searchString)
        //                                   || s.pd_Description.Contains(searchString));
        //        }
        //        switch (sortOrder)
        //        {
        //            case "name_desc":
        //                students = students.OrderByDescending(s => s.pd_Name);
        //                break;
        //            case "Date":
        //                students = students.OrderBy(s => s.pd_Name);
        //                break;
        //            case "date_desc":
        //                students = students.OrderByDescending(s => s.pd_Name);
        //                break;
        //            default:
        //                students = students.OrderBy(s => s.pd_Name);
        //                break;
        //        }

        //        int pageSize = 7;
        //        return View( PaginatedList<Products>.Create(students.AsNoTracking(), pageNumber ?? 1, pageSize));
        //    }


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

        ////[HttpGet]
        //public IActionResult Index()
        //{


        //    return View();
        //}
    }
}
