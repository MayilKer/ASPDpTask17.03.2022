using ASPDbTask.DAL;
using ASPDbTask.Models;
using ASPDbTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDbTask.Controllers
{
    public class HomeController : Controller
    {
        private DbContextTask _context { get;}
        public HomeController(DbContextTask context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            List<Category> categories = _context.Categories
                .Include(p=>p.Products)
                .ToList();
            HomeVM homeVM = new HomeVM
            {
                Products = products,
                Categories = categories
            };
            return View(homeVM);
        }
    }
}
