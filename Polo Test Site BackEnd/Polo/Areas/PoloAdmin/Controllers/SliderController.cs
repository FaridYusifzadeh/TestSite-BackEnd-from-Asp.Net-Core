using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Polo.DAL;
using Polo.Extentions;
using Polo.Models;

namespace Polo.Areas.PoloAdmin.Controllers
{

    [Area("PoloAdmin")]
    public class SliderController : Controller
    {
        private AppDbContext _context;

        private IHostingEnvironment _env;

        public SliderController(AppDbContext context , IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }



        public IActionResult Index()
        {

            return View(_context.Sliders);
        }


        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if(ModelState["Title"].ValidationState == ModelValidationState.Invalid 
                || ModelState["Description"].ValidationState == ModelValidationState.Invalid 
                || ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if(!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil novunu duz secin");
                return View();
            }

            if(!slider.Photo.CheckImageSize(2))
            {
                ModelState.AddModelError("Photo", "Shekil hecmi coxdur");
                return View();
            }

            string filename = await slider.Photo.CopyImage(_env.WebRootPath,"sliders");

            slider.Image = filename;
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}