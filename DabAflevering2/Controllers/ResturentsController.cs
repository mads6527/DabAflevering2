using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DabAflevering2.Models;
using DabAflevering2.ViewModels;
using DabAflevering2.Services;



namespace DabAflevering2.Controllers
{
    public class ResturentsController : Controller
    {
        private IListResturentsService _Repo;
        private readonly ResturentContext _context;

        public ResturentsController(IListResturentsService repo, ResturentContext context)
        {
            _Repo = repo;
            _context = context;

        }

        // GET: Resturents
        public IActionResult Index()
        {
            var viewmodel = new ResturentIndexData();
            viewmodel.Resturents = _Repo.GetAllResturentsWithAverageRating();
  
            return View(viewmodel);
        }

        public IActionResult Menu(int? id)
        {
            var viewmodel = new ResturentMenu();
            viewmodel.Menu = _Repo.GetMenuForResturent(id);

            if(viewmodel.Menu == null)
            {
                return Content("Angive Resturent med Id i URL");
            }

            return View(viewmodel);
        }

        public IActionResult GuestReview(int? id)
        {
            var viewmodel = new GuestReviews();
            viewmodel.guest_reviews = _Repo.GuestsReviews(id);

            if (viewmodel.guest_reviews == null)
            {
                return Content("Angiv Et resturant ID, for gæste reviews for den specifikke resturant");
            }

            return View(viewmodel);
        }


        
        // GET: Resturents1/Create
        public IActionResult CreateResturent()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateResturent([Bind("ResturentId,Type,Name,Address")] Resturent resturent)
        {
            if (ModelState.IsValid)
            {
                
               // _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Resturent ON"); skulle fikse så man kan create med resturentID men constraints er fucked. ;(
                _context.Add(resturent);
                await _context.SaveChangesAsync();
               
                return RedirectToAction(nameof(Index));
            }
            return View(resturent);
        }


        public IActionResult CreateReview()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateReview([Bind("ReviewId, Stars, Text, ResturentId")] Review Review)
        {

            if (ModelState.IsValid)
            {
                _context.Add(Review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Review);
        }



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
