using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace School.Controllers
{
    // [Route("[controller]")]
    public class TeacherController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(){
            return View();
        }
    }
}