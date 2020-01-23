using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCM.Models;

namespace SCM.Controllers
{
    public class Item_CategoryController : Controller
    {
        // GET: Item_Category
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(Item_Category ic)
        {
            return View();
        }
    }
}