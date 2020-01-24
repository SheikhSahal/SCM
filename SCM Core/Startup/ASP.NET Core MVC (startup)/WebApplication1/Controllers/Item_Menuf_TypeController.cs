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

            return View();
        }
    }
}