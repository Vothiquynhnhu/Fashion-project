using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;

namespace Web_Shoes.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CouponManagementController : Controller
    {
        private readonly ApplicationDbContext _context;



        public CouponManagementController(ApplicationDbContext context)
        {
            _context = context;

        }

        // GET: RoleManagementController
        [Route("/couponsmanagement")]
        [HttpGet]
        public IActionResult Index()
        {
            var couponQuery = from a in _context.Coupons select a;

            return View(couponQuery);
        }


        [Route("/couponsmanagement/create")]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost("/couponsmanagement/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Coupons coupon)
        {
            try
            {
                var CreateCoupon = new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponAmount = coupon.couponAmount,
                    couponCode = coupon.couponCode,
                    couponPrice = coupon.couponPrice
                };

                _context.Coupons.Add(CreateCoupon);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }


        [Route("/couponsmanagement/edit/{id:guid}")]
        public IActionResult Edit(string id)
        {
            try
            {
                var editQuery = _context.Coupons.FirstOrDefault(a => a.couponId == id);

                return View(editQuery);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("/couponsmanagement/edit/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Coupons coupon)
        {
            try
            {
                var editQuery = _context.Coupons.FirstOrDefault(a => a.couponId == coupon.couponId);
                editQuery.couponCode = coupon.couponCode;
                editQuery.couponPrice = coupon.couponPrice;
                editQuery.couponAmount = coupon.couponAmount;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }


        [Route("/couponsmanagement/delete/{id:guid}")]
        public IActionResult Delete(string id)
        {
            try
            {

                var editQuery = _context.Coupons.FirstOrDefault(a => a.couponId == id);

                return View(editQuery);


            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("/couponsmanagement/delete/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Coupons coupon)
        {
            try
            {
                var editQuery = _context.Coupons.FirstOrDefault(a => a.couponId == coupon.couponId);

                _context.Coupons.Remove(editQuery);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
