using Lab5_RubikStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_RubikStore.Controllers
{
    public class RubikStoreController : Controller
    {
        RubikStoreDataContext data = new RubikStoreDataContext();
        // GET: RubikStore
        public ActionResult Index()
        {
            var all_rubik = from s in data.Rubiks select s;
            return View(all_rubik);
        }
    }
}