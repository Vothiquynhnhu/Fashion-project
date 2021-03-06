using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class UserManagementController : Controller
    {

        private readonly ApplicationDbContext _context;
        //private readonly UserManager<AppUser> _userManager;

        public UsersModel usersModel;

        private readonly RoleManager<AppRole> _roleManager;

        private readonly UserManager<AppUser> _userManager;
        public UserManagementController(ApplicationDbContext context, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        [Route("/usermanagement")]
        [HttpGet]
        // GET: UserManagementController
        public async Task<ActionResult> Index()
        {
            //var userQuery = from a in _context.AppUser select a;
            var userQuery = await _userManager.Users.ToListAsync();

            
            List<UserListModel> userListModel = new List<UserListModel>();
            foreach (var item in userQuery)
            {

                var roles = await _userManager.GetRolesAsync(item);
                string role;
                if (roles == null)
                {
                    role = "";
                }
                else
                {
                    role = roles[0].ToString();
                }

                var User = new UserListModel()
                {
                    User_Id = item.Id,
                    User_FirstName = item.FirstName,
                    User_LastName = item.LastName,
                    User_UserName = item.UserName,
                    User_Role = role,
                    User_Email = item.Email
                };
                userListModel.Add(User);
            }
            

            return View(userListModel);
        }

        // GET: UserManagementController/Details/5
        [Route("/usermanagement/details/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Details(string id)
        {

 
            var userQuery = await _userManager.FindByIdAsync(id);

            List<UserListModel> userListModel = new List<UserListModel>();
            

            var roles = await _userManager.GetRolesAsync(userQuery);
            string role;
            if (roles == null)
            {
                role = "";
            }
            else
            {
                role = roles[0].ToString();
            }

            var User = new UserListModel()
            {
                User_Id = userQuery.Id,
                User_FirstName = userQuery.FirstName,
                User_LastName = userQuery.LastName,
                User_UserName = userQuery.UserName,
                User_Role = role,
                User_Email = userQuery.Email
            };
            userListModel.Add(User);
            

            return View(userListModel[0]);
        }

        // GET: UserManagementController/Create
        [Route("/usermanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManagementController/Create
        [HttpPost("/usermanagement/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AppUser appUser)
        {
            try
            {

                var hasher = new PasswordHasher<AppUser>();

                var CreateUser = new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = appUser.UserName,
                    NormalizedUserName = appUser.UserName,
                    NormalizedEmail = appUser.Email,
                    Email = appUser.Email,
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, appUser.PasswordHash),
                    SecurityStamp = string.Empty,
                    FirstName = appUser.FirstName,
                    LastName = appUser.LastName,
                    DoB = appUser.DoB
                };

                var userQuery = await _userManager.CreateAsync(CreateUser);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManagementController/Edit/5
        [Route("/usermanagement/edit/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {

            //var userQuery = _context.AppUser.FirstOrDefault(a => a.Id == id);
            var userQuery = await _userManager.FindByIdAsync(id);
            return View(userQuery);
        }

        // POST: UserManagementController/Edit/5
        [HttpPost("/usermanagement/edit/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, AppUser appUser)
        {
            try
            {

                //var userQuery = _context.AppUser.FirstOrDefault(a => a.Id == id);
                var userQuery = await _userManager.FindByIdAsync(id);

                userQuery.UserName = appUser.UserName;
                userQuery.FirstName = appUser.FirstName;
                userQuery.LastName = appUser.LastName;
                userQuery.Email = appUser.Email;
                userQuery.DoB = appUser.DoB;

                var userQueryEdit = await _userManager.UpdateAsync(userQuery);
                //_context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManagementController/Delete/5
        [Route("/usermanagement/delete/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Delete(string id)
        {

            //var userQuery = _context.Users.FirstOrDefault(x => x.Id == id);
            var userQuery = await _userManager.FindByIdAsync(id);

            return View(userQuery);
        }

        // POST: UserManagementController/Delete/5
        [HttpPost("/usermanagement/delete/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {

                //var userQuery = _context.AppUser.FirstOrDefault(x => x.Id == id);
                var userQuery = await _userManager.FindByIdAsync(id);

                string aa = userQuery.LastName;


                var userQueryDelete = await _userManager.DeleteAsync(userQuery);

                //_context.AppUser.Remove(userQuery);
                //_context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [BindProperty]
        public string RoleName { set; get; }

        // GET: RoleManagementController/userinrole/5
        [Route("/usermanagement/userinrole/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> UserInRole(string id)
        {
            
            var userQuery = await _userManager.FindByIdAsync(id);

            var roleQuery = await _roleManager.Roles.ToListAsync();


            ViewBag.Id = id;
            ViewBag.UserName = userQuery.UserName;
            ViewBag.FirstName = userQuery.FirstName;
            ViewBag.LastName = userQuery.LastName;
            ViewBag.Email = userQuery.Email;

            return View(roleQuery);
        }

        // POST: RoleManagementController/userinrole/511

        [HttpPost("/usermanagement/userinrole/{id:guid}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UserInRoleAsync(string id, IFormCollection collection,AppRole appRole)
        {


            try
            {

                string idUser = Request.Form["id_User"];

                string RoleName = Request.Form["NameSelect"];

                //var roleQueryId = _context.AppRole.FirstOrDefault(a => a.Name == RoleName);
                var userQuery = await _userManager.FindByIdAsync(idUser);
                var roleQueryId = await _roleManager.FindByNameAsync(RoleName);

                var currentRole = await _userManager.GetRolesAsync(userQuery);
                if (currentRole.Count >0)
                {
                    var userDelete = _userManager.RemoveFromRoleAsync(userQuery,currentRole[0].ToString());
                }

                var userQueryCreate = _userManager.AddToRoleAsync(userQuery,RoleName);



                return RedirectToAction(nameof(Index));
            }
            catch 
            {

                return View();
            }
        }
    }
}
