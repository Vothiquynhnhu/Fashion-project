using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Models;
using Web_Fashion.Service;

namespace Web_Fashion.Controllers
{
    public class WonmanController : Controller
    {

        private readonly ApplicationDbContext _context;

        public WonmanController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/woman")]
        [HttpGet]
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

            query = query.Where(x => x.c.cg_Name == "women");

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(s => s.a.pd_Name.Contains(searchString)
                                       || s.a.pd_Description.Contains(searchString));
            }


            if (priceOrder == "All")
            {
                ViewData["FirstPriceSort"] = "All";
            }
            else
            {
                if (priceOrder == null)
                {
                    ViewData["FirstPriceSort"] = "";
                }
                else
                {
                    ViewData["FirstPriceSort"] = priceOrder;
                }

            }


            switch (priceOrder)
            {
                case "0":
                    query = query.Where(s => s.a.pd_Price <= 50);
                    query = query.OrderByDescending(s => s.a.pd_Price);
                    break;
                case "51":
                    query = query.Where(s => s.a.pd_Price >= 50 && s.a.pd_Price <= 100);
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
    }
}
