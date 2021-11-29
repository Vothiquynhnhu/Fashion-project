using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Fashion.Controllers
{
    public class LoginAdminController : Controller
    {

        [Route("/loginadmin")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
