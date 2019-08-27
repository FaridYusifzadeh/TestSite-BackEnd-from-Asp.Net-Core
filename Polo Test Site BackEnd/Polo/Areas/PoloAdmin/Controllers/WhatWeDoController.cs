using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polo.DAL;
using Polo.Models;

namespace Polo.Areas.PoloAdmin.Controllers
{
    [Area("PoloAdmin")]
    public class WhatWeDoController : Controller
    {
        private AppDbContext _context;
        public WhatWeDoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.WhatWeDos);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            WhatWeDo skill =await _context.WhatWeDos.FindAsync(id);
            if(skill==null) return NotFound();
            return View(skill);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WhatWeDo skill)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.WhatWeDos.AddAsync(skill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            WhatWeDo skill = await _context.WhatWeDos.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            WhatWeDo skill = await _context.WhatWeDos.FindAsync(id);
            _context.WhatWeDos.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            WhatWeDo skill =await _context.WhatWeDos.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, WhatWeDo skill)
        {
            //WhatWeDo dbSkill = await _context.WhatWeDos.FindAsync(id);
            if (!ModelState.IsValid)
            {
                return View(skill);
            }

            //dbSkill.Title = skill.Title;
            //dbSkill.Description = skill.Description;
            //await _context.SaveChangesAsync();

            _context.Entry(skill).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


    }
}