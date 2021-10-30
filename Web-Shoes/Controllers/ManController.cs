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
        public IActionResult Index(int? pageNumber)
        {
            var query = from a in _context.Products
                        join b in _context.ProductsInCategories on a.pd_Id equals b.pic_productId
                        join c in _context.Categories on b.pic_CategoriesId equals c.cg_Id
                        select new { a, c };

            query = query.Where(x => x.c.cg_Name == "man");



            var productModelQuery = query
                .Select(x => new ProductModel()
                {
                    pd_Id = x.a.pd_Id,
                    pd_Img1 = x.a.pd_Img1,
                    pd_Name = x.a.pd_Name,
                    pd_Price = x.a.pd_Price

                });
            //PaginatedList<Products>.Create(students.AsNoTracking(), pageNumber ?? 1, pageSize)
            //productModelQuery

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
