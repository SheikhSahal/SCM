using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Database;

namespace WebApplication1.Controllers
{
    public class Item_Menuf_TypeController : Controller
    {
        DB database = new DB();

        public IActionResult Index()
        {
            Item_Menuf_Type Item_Menuf = database.Item_Menuf_type_id_Generate();

            ViewBag.Item_Menuf_id = Item_Menuf;

            List<Item_Category> Item_Cat_dropdown = database.ItemCat_dropdown();

            ViewBag.Item_Cat_DD = Item_Cat_dropdown;

            return View();
        }


        [HttpPost]
        public JsonResult Index(Item_Menuf_Type imt)
        {
            bool status = false;


            Item_Menuf_Type Item_Menuf = database.Item_Menuf_type_id_Generate();

            imt.Mtype_id = Item_Menuf.Mtype_id;


            database.Insert_Item_Menuf_Type(imt);
            status = true;

            return Json(new { success = status });
        }

        public IActionResult GetData()
        {
            Item_Menuf_Type Item_Menuf = database.Item_Menuf_type_id_Generate();

            return Json(new { success = true, fetchdata = Item_Menuf.Mtype_id });
        }
    }
}