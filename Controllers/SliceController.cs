using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Breaddit.Data;
using Breaddit.Models;

namespace Breaddit.Controllers
{
    public class SliceController : Controller
    {
        private readonly BreadditContext _context;

        public SliceController(BreadditContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Slice.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slice = await _context.Slice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slice == null)
            {
                return NotFound();
            }

            return View(slice);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,UserId")] Slice slice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slice);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slice = await _context.Slice.FindAsync(id);
            if (slice == null)
            {
                return NotFound();
            }
            return View(slice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Followers,UserId")] Slice slice)
        {
            if (id != slice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliceExists(slice.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(slice);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slice = await _context.Slice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slice == null)
            {
                return NotFound();
            }

            return View(slice);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slice = await _context.Slice.FindAsync(id);
            _context.Slice.Remove(slice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SliceExists(int id)
        {
            return _context.Slice.Any(e => e.Id == id);
        }
    }
}
