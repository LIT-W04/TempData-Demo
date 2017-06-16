using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            PersonViewModel vm = new PersonViewModel();
            vm.Person = new Person();
            if (Session["Person"] != null)
            {
                vm.Person = (Person) Session["Person"];
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult Submit(Person person)
        {
            Session["Person"] = person;
            PersonViewModel vm = new PersonViewModel();
            vm.Person = person;
            return View(vm);
        }
    }
}