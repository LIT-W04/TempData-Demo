using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewModel vm = new ViewModel();
            int count = 0;
            if (Session["ViewCount"] != null)
            {
                count = (int) Session["ViewCount"];
            }

            count++;
            Session["ViewCount"] = count;
            vm.ViewCount = count;


            if (Session["MyClass"] != null)
            {
                vm.MyClass = (MyClass) Session["MyClass"];
            }
            else
            {
                MyClass mc = new MyClass
                {
                    RandomNumber = new Random().Next(1, 10000)
                };
                Session["MyClass"] = mc;
                vm.MyClass = mc;
            }

            return View(vm);
        }
    }

    
}