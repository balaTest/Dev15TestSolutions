﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_Anc20_core_NoAuth_1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp_Anc20_core_NoAuth_1.Controllers
{
    public class BlogsController : Controller
        public BlogsController(BloggingContext context)
        public IActionResult Index()
        public IActionResult Create()
        [HttpPost]
            return View(blog);
    }
}