﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Openslava 2017";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "DevOps Skills";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
