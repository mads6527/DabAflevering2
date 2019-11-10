using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DabAflevering2.Models;
using DabAflevering2.ViewModels;

namespace DabAflevering2.Services
{
    public interface IListResturentsService
    {
        IEnumerable<Resturent> GetAllResturentsWithAverageRating();

        Resturent GetMenuForResturent(int? id);

        IEnumerable<Guest> GuestsReviews();
    }
}
