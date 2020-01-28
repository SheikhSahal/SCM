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
        DB database = new DB();

        public IActionResult Index()
        {
            Scm_Supplier SCM_supp_id = database.SCM_Supplier_id_Generate();

            ViewBag.scm_supp_id = SCM_supp_id;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Scm_Supplier ss)
        {
            bool status = false;
            string R_Status = null;

            if (ss.Supp_STATUS == true)
            {
                R_Status = "Y";
            }
            else
            {
                R_Status = "N";
            }

            Scm_Supplier SCM_supp_id = database.SCM_Supplier_id_Generate();
            ss.SUPP_id = SCM_supp_id.SUPP_id;

            database.Insert_SCM_Supplier(ss, R_Status);

            foreach(var details_record in ss.Scm_Supplier_details)
            {
                database.Insert_SCM_Supplier_Details(details_record,ss.SUPP_id);
            }
            status = true;

            return Json(new { success = status });
        }

        public IActionResult GetData()
        {
            Scm_Supplier SCM_supp_id = database.SCM_Supplier_id_Generate();

            return Json(new { success = true, fetchdata = SCM_supp_id.SUPP_id });
        }
    }
}