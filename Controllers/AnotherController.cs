using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreFirstProject.Controllers
{
    public class AnotherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String DoSomething() {
            return "Something being done";
        }

        public IActionResult StartupView() {
            return View();
        }
    }
}