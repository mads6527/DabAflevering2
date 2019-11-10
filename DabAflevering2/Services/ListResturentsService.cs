using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using DabAflevering2.Models;
using DabAflevering2.ViewModels;

namespace DabAflevering2.Services
{
    public class ListResturentsService : IListResturentsService
    {
        private ResturentContext _resturentContext;

        public ListResturentsService(ResturentContext resturentContext)
        {
            _resturentContext = resturentContext;
        }

        public IEnumerable<Resturent> GetAllResturentsWithAverageRating()
        {
            var viewmodel = _resturentContext.Resturent
                .Include(r => r.Reviews)
                .ToList();
                

            return viewmodel;
        }

        public Resturent GetMenuForResturent(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var view = _resturentContext.Resturent
                .Include(r => r.ResturentDishes)
                    .ThenInclude(r => r.Dish)
                        .ThenInclude(r => r.Review)
                .Single(r => r.ResturentId == id);

            return view;
        }
    }
}
