﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloCoreMVC.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}