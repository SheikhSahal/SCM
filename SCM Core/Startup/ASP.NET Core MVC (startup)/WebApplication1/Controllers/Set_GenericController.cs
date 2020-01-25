using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Database;

namespace WebApplication1.Controllers
{
    public class Set_GenericController : Controller
    {
        DB database = new DB();

        public IActionResult Index()
        {

            Set_Generic generic_id = database.Set_Generic_id_Generate();
            ViewBag.Item_sub_cate = generic_id;


            List<Item_Category> Item_Cat_dropdown = database.ItemCat_dropdown();
            ViewBag.Item_Cat_DD = Item_Cat_dropdown;


            List<Item_Sub_Cateogory> Item_Sub_Cat_dropdown = database.Item_Sub_Cat_dropdown();
            ViewBag.Item_sub_cat_DD = Item_Sub_Cat_dropdown;
            

            return View();
        }

        [HttpPost]
        public JsonResult Index(Set_Generic sg)
        {
            bool status = false;
            Set_Generic generic_id = database.Set_Generic_id_Generate();

            sg.Generic_id = generic_id.Generic_id;

            database.Insert_Generic(sg);
            status = true;


            return Json(new { success = status });
        }


        public IActionResult GetData()
        {
            Set_Generic generic_id = database.Set_Generic_id_Generate();

            return Json(new { success = true, fetchdata = generic_id.Generic_id });
        }
    }
}