using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Fashion.Controllers
{
    public class AddToWishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
