using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Models;
using Web_Shoes.Entity;
using Microsoft.AspNetCore.Authorization;

namespace Web_Shoes.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeManagementController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeManagementController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: HomeManagementController
        [Route("/homemanagement/slider")]
        [HttpGet]
        public ActionResult Slider()
        {
            // Slider Home 
            var SliderQuery = from a in _context.SliderHomes select a;

            return View(SliderQuery);
        }

        // GET: HomeManagementController
        [Route("/homemanagement/categories")]
        [HttpGet]
        public ActionResult Categories()
        {
            // Categories Home
            var CategoriesQuery = from a in _context.CategoriesHomes select a;

            return View(CategoriesQuery);
        }

        // GET: HomeManagementController
        [Route("/homemanagement/customer")]
        [HttpGet]
        public ActionResult Customer()
        {
            // Customer Home 
            var CustomerQuery = from a in _context.CustomerHomes select a;

            return View(CustomerQuery);
        }



        // GET: HomeManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        
        // POST: HomeManagementController/Create
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


        //Edit ----------------------------------------------------------------------------------------------------------------------------------------------
        // GET: HomeManagementController/Edit/5
        [Route("/homemanagement/categories/{id:guid}")]
        [HttpGet]
        public ActionResult EditCategories(string id)
        {
            var categoriesQuery = _context.CategoriesHomes.FirstOrDefault(a => a.CategoriesHomeId == id);

            return View(categoriesQuery);
        }

        // POST: HomeManagementController/Edit/5
        [HttpPost("/homemanagement/categories/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditCategories(string id, CategoriesHome categoriesHome)
        {
            try
            {
                var categoriesEdit = _context.CategoriesHomes.FirstOrDefault(a => a.CategoriesHomeId == id);
                categoriesEdit.CategoriesHomeUrl1 = categoriesHome.CategoriesHomeUrl1;
                categoriesEdit.CategoriesHomeUrl2 = categoriesHome.CategoriesHomeUrl2;
                categoriesEdit.CategoriesHomeUrl3 = categoriesHome.CategoriesHomeUrl3;
                categoriesEdit.CategoriesHomeUrl4 = categoriesHome.CategoriesHomeUrl4;
                categoriesEdit.CategoriesHomeUrl5 = categoriesHome.CategoriesHomeUrl5;
                categoriesEdit.CategoriesHomeUrl6 = categoriesHome.CategoriesHomeUrl6;
                categoriesEdit.CategoriesHomeUrl7 = categoriesHome.CategoriesHomeUrl7;
                categoriesEdit.CategoriesHomeUrl8 = categoriesHome.CategoriesHomeUrl8;


                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeManagementController/Edit/5
        [Route("/homemanagement/slider/{id:guid}")]
        [HttpGet]
        public ActionResult EditSlider(string id)
        {
            var sliderQuery = _context.SliderHomes.FirstOrDefault(a => a.SliderId == id);

            return View(sliderQuery);
        }

        // POST: HomeManagementController/Edit/5
        [HttpPost("/homemanagement/slider/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditSlider(string id, SliderHome sliderHome)
        {
            try
            {
                var sliderEdit = _context.SliderHomes.FirstOrDefault(a => a.SliderId == id);
                sliderEdit.SliderUrl1 = sliderHome.SliderUrl1;
                sliderEdit.SliderUrl2 = sliderHome.SliderUrl2;
                sliderEdit.SliderUrl3 = sliderHome.SliderUrl3;
                sliderEdit.SliderUrl4 = sliderHome.SliderUrl4;
                sliderEdit.SliderUrl5 = sliderHome.SliderUrl5;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeManagementController/Edit/5
        [Route("/homemanagement/customer/{id:guid}")]
        [HttpGet]
        public ActionResult EditCustomer(string id)
        {
            var customerQuery = _context.CustomerHomes.FirstOrDefault(a => a.CustomerHomeId == id);

            return View(customerQuery);
        }

        // POST: HomeManagementController/Edit/5
        [HttpPost("/homemanagement/customer/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditCustomer(string id, CustomerHome customerHome)
        {
            try
            {
                var customerEdit = _context.CustomerHomes.FirstOrDefault(a => a.CustomerHomeId == id);
                customerEdit.CustomerHome_CDesription = customerHome.CustomerHome_CDesription;
                customerEdit.CustomerHome_CImg = customerHome.CustomerHome_CImg;
                customerEdit.CustomerHome_CName = customerHome.CustomerHome_CName;
                customerEdit.CustomerHome_CStar = customerHome.CustomerHome_CStar;
                customerEdit.CustomerHome_CWork = customerHome.CustomerHome_CWork;


                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }





        // GET: HomeManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeManagementController/Delete/5
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
