using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_Anc20_core_NoAuth_1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp_Anc20_core_NoAuth_1.Controllers
{
    public class BlogsController : Controller    {        private BloggingContext _context;
        public BlogsController(BloggingContext context)        {            _context = context;        }
        public IActionResult Index()        {            return View(_context.Blogs.ToList());        }
        public IActionResult Create()        {            return View();        }
        [HttpPost]        [ValidateAntiForgeryToken]        public IActionResult Create(Blog blog)        {            if (ModelState.IsValid)            {                _context.Blogs.Add(blog);                _context.SaveChanges();                return RedirectToAction("Index");            }
            return View(blog);        }
    }
}
