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
    }
}