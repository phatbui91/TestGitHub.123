using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestGitHub._123.Controllers
{
    public class TESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index123()
        {
            return View();
        }
        public IActionResult Index12345()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
    }
}