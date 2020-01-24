using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Database;

namespace WebApplication1.Controllers
{
    public class Item_CategoryController : Controller
    {
        DB database = new DB();

        public IActionResult Index()
        {
            Item_Category Item_Cat_id = database.Item_category_id_Generate();


            ViewBag.Item_Cate_id = Item_Cat_id;

            return View();
        }


        [HttpPost]
        public JsonResult Index(Item_Category ic)
        {
            string R_Status = null;

            bool status = false;

            if(ic.Status == true)
            {
                R_Status = "Y";
            }
            else
            {
                R_Status = "N";
            }

            Item_Category Item_Cat_id = database.Item_category_id_Generate();

            ic.Item_category_id = Item_Cat_id.Item_category_id;

            database.Insert_Item_Category(ic, R_Status);
            status = true;

            return Json(new { success = status });
        }


        public IActionResult GetData()
        {
            Item_Category Item_Cat_id = database.Item_category_id_Generate();

            return Json(new { success = true  , fetchdata= Item_Cat_id.Item_category_id });
        }


    }
}