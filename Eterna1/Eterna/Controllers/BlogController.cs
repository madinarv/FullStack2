﻿using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
