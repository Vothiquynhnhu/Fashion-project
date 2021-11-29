using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Data;
using Web_Fashion.Models;

namespace Web_Fashion.Controllers
{
    public class TopSellerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TopSellerController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/topseller")]
        [HttpGet("{id}")]
        public IActionResult Index()
        {
            var query = from a in _context.Products
                        join b in _context.ProductsInCategories on a.pd_Id equals b.pic_productId
                        join c in _context.Categories on b.pic_CategoriesId equals c.cg_Id
                        select new { a, c };

            query = query.Where(x => x.c.cg_Name == "topseller");



            var productModelQuery = query
                .Select(x => new ProductModel()
                {
                    pd_Id = x.a.pd_Id,
                    pd_Img1 = x.a.pd_Img1,
                    pd_Name = x.a.pd_Name,
                    pd_Price = x.a.pd_Price

                });


            return View(productModelQuery);
        }

        // GET: TopSellerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TopSellerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopSellerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopSellerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TopSellerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopSellerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TopSellerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
