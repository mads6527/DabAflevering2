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

        public ResturentsController(IListResturentsService repo)
        {
            _Repo = repo;
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
    }
}
