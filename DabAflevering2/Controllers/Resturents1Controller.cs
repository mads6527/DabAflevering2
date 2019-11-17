using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DabAflevering2.Models;

namespace DabAflevering2.Controllers
{
    public class Resturents1Controller : Controller
    {
        private readonly ResturentContext _context;

        public Resturents1Controller(ResturentContext context)
        {
            _context = context;
        }

        // GET: Resturents1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resturent.ToListAsync());
        }

        // GET: Resturents1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resturent = await _context.Resturent
                .FirstOrDefaultAsync(m => m.ResturentId == id);
            if (resturent == null)
            {
                return NotFound();
            }

            return View(resturent);
        }

        // GET: Resturents1/Create
        public IActionResult CreateResturent()
        {
            return View();
        }

        // POST: Resturents1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateResturent([Bind("ResturentId,Type,Name,Address")] Resturent resturent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resturent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resturent);
        }

        // GET: Resturents1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resturent = await _context.Resturent.FindAsync(id);
            if (resturent == null)
            {
                return NotFound();
            }
            return View(resturent);
        }

        // POST: Resturents1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResturentId,Type,Name,Address")] Resturent resturent)
        {
            if (id != resturent.ResturentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resturent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResturentExists(resturent.ResturentId))
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
            return View(resturent);
        }

        // GET: Resturents1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resturent = await _context.Resturent
                .FirstOrDefaultAsync(m => m.ResturentId == id);
            if (resturent == null)
            {
                return NotFound();
            }

            return View(resturent);
        }

        // POST: Resturents1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resturent = await _context.Resturent.FindAsync(id);
            _context.Resturent.Remove(resturent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResturentExists(int id)
        {
            return _context.Resturent.Any(e => e.ResturentId == id);
        }
    }
}
