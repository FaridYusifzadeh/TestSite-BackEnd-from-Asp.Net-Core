using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polo.DAL;
using Polo.ViewModels;

namespace Polo.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel
            {
                Sliders=_context.Sliders,
                Descriptions=_context.Descriptions,
                Welcomes = _context.Welcomes,
                WhatWeDos=_context.WhatWeDos,
                OurWorks=_context.OurWorks
                

            };
            return View(homeModel);
        }
    }
}