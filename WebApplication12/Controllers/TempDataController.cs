using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            PersonViewModel vm = new PersonViewModel();
            if (TempData["Person"] != null)
            {
                vm.Person = (Person) TempData["Person"];
            }
            return View(vm);
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(Person person)
        {
            //make believe we submit person to database
            TempData["Person"] = person;
            return Redirect("/tempdata/index");
        }
    }
}