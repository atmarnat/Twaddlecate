﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Controllers
{
    public class EntertainmentController : Controller
    {
        [HttpGet]
        public IActionResult First()
        {
            return View();
        }
        public IActionResult WoW()
        {
            return View();
        }
    }
}