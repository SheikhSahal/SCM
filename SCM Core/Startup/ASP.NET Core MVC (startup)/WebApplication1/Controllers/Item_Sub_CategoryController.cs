using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Database;

namespace WebApplication1.Controllers
{
    public class Item_Sub_CategoryController : Controller
    {
        DB database = new DB();

        public IActionResult Index()
        {

            Item_Sub_Cateogory Item_sub_cat = database.Item_Sub_Cateogory_id_Generate();

            ViewBag.Item_sub_cate = Item_sub_cat;

            List<Item_Category> Item_Cat_dropdown = database.ItemCat_dropdown();

            ViewBag.Item_Cat_DD = Item_Cat_dropdown;


            return View();
        }

        [HttpPost]
        public JsonResult Index(Item_Sub_Cateogory isc)
        {

            string R_Status = null;

            bool status = false;

            if (isc.Status == true)
            {
                R_Status = "Y";
            }
            else
            {
                R_Status = "N";
            }


            Item_Sub_Cateogory Item_sub_cat = database.Item_Sub_Cateogory_id_Generate();

            isc.Isubcate_id = Item_sub_cat.Isubcate_id;


            database.Insert_Item_SubCategory(isc, R_Status);
            status = true;

            return Json(new { success = status });
        }


        public IActionResult GetData()
        {
            Item_Sub_Cateogory Item_sub_cat = database.Item_Sub_Cateogory_id_Generate();

            return Json(new { success = true, fetchdata = Item_sub_cat.Isubcate_id });
        }
    }
}