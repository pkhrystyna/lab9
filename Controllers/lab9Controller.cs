using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class lab9Controller : Controller
    {
        // GET: lab9
        public ActionResult FirstViewMethod()
        {
            List<string> vegetables = GetVegetablesList();
            return View(vegetables);
        }
        public ActionResult SecondViewMethod()
        {
            return View(GetVegetablesList().OrderBy(x => x).ToList());
        }
        public ActionResult ThirdViewMethod()
        {
            return View(GetVegetablesList().OrderBy(x => x).ToList());
        }
        public List<string> GetVegetablesList()
        {
            List<string> vegetables = new List<string>();
            vegetables.Add("Помідор");
            vegetables.Add("Огірок");
            vegetables.Add("Картопля");
            vegetables.Add("Кабачок");
            vegetables.Add("Баклажан");
            vegetables.Add("Капуста");
            vegetables.Add("Броколі");

            return vegetables;
        }

    }
}