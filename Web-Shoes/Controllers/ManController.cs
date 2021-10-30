using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;
using Web_Shoes.Service;

namespace Web_Shoes.Controllers
{
    public class ManController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ManController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/man")]
        [HttpGet("{id}")]
        public IActionResult Index(string priceOrder, string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var query = from a in _context.Products
                        join b in _context.ProductsInCategories on a.pd_Id equals b.pic_productId
                        join c in _context.Categories on b.pic_CategoriesId equals c.cg_Id
                        select new { a, c };

            query = query.Where(x => x.c.cg_Name == "man");

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(s => s.a.pd_Name.Contains(searchString)
                                       || s.a.pd_Description.Contains(searchString));
            }

            if (sortOrder != "All" )
            {
                //switch (sortOrder)
                //{
                //    case "name_desc":
                //        students = students.OrderByDescending(s => s.pd_Name);
                //        break;
                //    case "Date":
                //        students = students.OrderBy(s => s.pd_Name);
                //        break;
                //    case "date_desc":
                //        students = students.OrderByDescending(s => s.pd_Name);
                //        break;
                //    default:
                //        students = students.OrderBy(s => s.pd_Name);
                //        break;
                //}
            }

            if (priceOrder != "All")
            {
                switch (priceOrder)
                {
                    case "0":
                        query = query.Where(s => s.a.pd_Price <=50);
                        query = query.OrderByDescending(s => s.a.pd_Price);
                        break;
                    case "51":
                        query = query.Where(s => s.a.pd_Price >= 50 && s.a.pd_Price <=100);
                        query = query.OrderBy(s => s.a.pd_Price);
                        break;
                    case "101":
                        query = query.Where(s => s.a.pd_Price >= 50 && s.a.pd_Price <= 100);
                        query = query.OrderByDescending(s => s.a.pd_Price);
                        break;
                    case "151":
                        query = query.Where(s => s.a.pd_Price >= 50 && s.a.pd_Price <= 100);
                        query = query.OrderByDescending(s => s.a.pd_Price);
                        break;
                    default:
                        query = query.OrderBy(s => s.a.pd_Name);
                        break;
                }
            }

            var productModelQuery = query
                .Select(x => new ProductModel()
                {
                    pd_Id = x.a.pd_Id,
                    pd_Img1 = x.a.pd_Img1,
                    pd_Name = x.a.pd_Name,
                    pd_Price = x.a.pd_Price

                });
            

            int pageSize = 8;
            return View(PaginatedList<ProductModel>.Create(productModelQuery.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [Route("/search")]
        [HttpPost]
        public IActionResult Search()
        {
            string search = Request.Form["search"];

            var searchQuery = _context.Products.Where(a => a.pd_Name.Contains(search) || a.pd_Description.Contains(search) || a.pd_Price.ToString() == search);

            return View(searchQuery);
        }

        
        


    }
}
