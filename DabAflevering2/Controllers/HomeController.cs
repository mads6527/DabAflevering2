using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DabAflevering2.Models;
using DabAflevering2.Views;
using Microsoft.EntityFrameworkCore;

namespace DabAflevering2.Controllers
{
    public class HomeController : Controller
    {
        private ResturentContext context_;
        public HomeController(ResturentContext context)
        {
            context_ = context;
        }
        
        public IActionResult Index()
        {
            List <ViewModel> viewModels = new List<ViewModel>();
            int tempaverage = new int();

            ViewModel tempModel = new ViewModel();

            var context = context_.Resturent
                .Include(p => p.Reviews)
                .Select(r => new ViewModel
                {
                    _resturentname = r.Name,
                    _type = r.Type,
                    _reviews = r.Reviews
                })
                .ToList();




                /*
            foreach (var resturent in context)
            {
                ViewModel _tempmodel = new ViewModel();
                _tempmodel._resturentname = resturent.Name;
                context_.Review.Where(c=>c.ResturentId == resturent.ResturentId).Load();
                foreach (Review c in resturent.Reviews)
                {
                    tempaverage += c.Stars;
                    for (int i = 0; i < 5; i++)
                    {
                        _tempmodel._reviews.Add(c);
                    }
                }

                tempaverage = tempaverage / resturent.Reviews.Count();
                _tempmodel._average = tempaverage;
                viewModels.Add(_tempmodel);
            }*/
            
            return View(context);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
