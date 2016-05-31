using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contains_Test.Models;
using HelperContainsClass;

namespace Contains_Test.Controllers
{
    public class ContainsController : Controller
    {
        // GET: Contains
        public ActionResult Index()
        {
            List<Cars> CarsList = new List<Cars>();
            CarsList.Add(new Cars(1, "BMW", 35255));
            CarsList.Add(new Cars(2, "Opel", 46933));
            CarsList.Add(new Cars(31, "Ford", 15151));
            CarsList.Add(new Cars(4, "Audi", 55199));

            ContainsViewModel model = new ContainsViewModel();
            if(CarsList.Contains(new Cars(2, "BMW", 35255)))
            {
                model.Text = "Det passer på indhold!";
            }
            else
            {
                model.Text = "Desværre";
            }

            return View(model);
        }
    }
}