using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;

namespace Web_Shoes.Controllers
{
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
    }
}
