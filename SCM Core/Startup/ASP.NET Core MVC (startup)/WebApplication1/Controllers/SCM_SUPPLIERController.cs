using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Database;

namespace WebApplication1.Controllers
{
    public class SCM_SUPPLIERController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Scm_Supplier ss)
        {
            return View();
        }
    }
}