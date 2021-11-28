using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;

namespace Web_Shoes.Controllers
{
    public class RoleManagementController : Controller
    {

        private readonly ApplicationDbContext _context;

        private  RoleManager<AppRole> _roleManager;


        public RoleManagementController(RoleManager<AppRole> roleManager, ApplicationDbContext context)
        {
            _context = context;
            _roleManager = roleManager;
        }

        // GET: RoleManagementController
        [Route("/rolemanagement")]
        [HttpGet]
        public async Task<ActionResult> Index()
        {

            //var roleQuery = from a in _context.AppRole select a;
            var roleQuery = await _roleManager.Roles.ToListAsync();
            return View(roleQuery);
        }


       // GET: RoleManagementController/Details/5
       [Route("/rolemanagement/details/{id:guid?}")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var roleQuery = _context.AppRole.FirstOrDefault(a => a.Id == id);
           

            return View(roleQuery);
        }

        // GET: RoleManagementController/Create
        [Route("/rolemanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        // POST: RoleManagementController/Create
        [HttpPost("/rolemanagement/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AppRole appRole)
        {
            try
            {
                appRole = new AppRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = appRole.Description,
                    Name = appRole.Name,
                    NormalizedName = appRole.NormalizedName,
                    ConcurrencyStamp = appRole.ConcurrencyStamp

                };


                await _roleManager.CreateAsync(appRole);

                //_context.AppRole.Add(appRole);

                //await _context.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleManagementController/Edit/5
        [Route("/rolemanagement/edit/{id:guid}")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var roleQuery = _context.AppRole.FirstOrDefault(x => x.Id == id);

            return View(roleQuery);
        }

        // POST: RoleManagementController/Edit/5
        [HttpPost("/rolemanagement/edit/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, AppRole appRole)
        {
            try
            {
                //var roleQuery = _context.AppRole.FirstOrDefault(a => a.Id == id);
                 var roleQuery = await _roleManager.FindByIdAsync(id);

                roleQuery.Description = appRole.Description;
                roleQuery.Name = appRole.Name;
                roleQuery.NormalizedName = appRole.NormalizedName;
                roleQuery.ConcurrencyStamp = appRole.ConcurrencyStamp;

                await _roleManager.UpdateAsync(roleQuery);

                //_context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleManagementController/Delete/5
        [Route("/rolemanagement/delete/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Delete(string id)
        {
            //var roleQuery = _context.AppRole.FirstOrDefault(a => a.Id == id);
            var roleQuery =  await _roleManager.FindByIdAsync(id);

            return View(roleQuery);
        }

        // POST: RoleManagementController/Delete/5
        [HttpPost("/rolemanagement/delete/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, AppRole appRole)
        {
            try
            {
                //var roleQuery = _context.AppRole.FirstOrDefault(a => a.Id == id);
                var roleQuery = await _roleManager.FindByIdAsync(id);

                
                await _roleManager.DeleteAsync(roleQuery);
                //_context.AppRole.Remove(roleQuery);
                //_context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



    }
}
