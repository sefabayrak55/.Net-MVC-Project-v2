﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin, Editor")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
