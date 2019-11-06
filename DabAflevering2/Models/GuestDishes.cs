using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DabAflevering2.Models
{
    public class GuestDishes
    {
        public Guest Guest { get; set; }
        public int PersonId { get; set; }
        public Dish Dish { get; set; }
        public int DishId { get; set; }
    }
}
