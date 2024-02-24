using Diff_ViewBag_ViewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diff_ViewBag_ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message1"] = "Data comes from ViewData  !!";
            ViewBag.Message2 = "Data comes from ViewBag !!";

            ViewData["CurrentDate1"] = DateTime.Now.ToString();
            ViewBag.CurrentDate2 = DateTime.Now.ToString();

            string[] games = { "Hockey", "Football", "Cricket", "Baseball" };

            ViewData["GamesArray1"] = games;
            ViewBag.GamesArray2 = games;

            Employee Asim = new Employee();
            Asim.EmpId = 11;
            Asim.EmpName = "Asim Khan";
            Asim.EmpAge = 25;

            ViewData["Employee1"] = Asim;
            ViewBag.Employee2 = Asim;

            return View();
        }
    }
}