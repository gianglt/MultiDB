using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiDB.Models;

namespace MultiDB.Controllers
{
    public class HomeController : Controller
    {
        public DBDieuHanh db;
        public ActionResult Index()
        {
            Session.Add("dbName", "dieuhanh2020");

            var nameDB = Session["dbName"] as string;
            db = new DBDieuHanh(nameDB);

            Session.Add("theDB", db);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}