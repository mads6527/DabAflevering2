using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DabAflevering2.Models
{
    public class Dish 
    {
        //Attributes
        public int DishId { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        //Navigation properties
        public ICollection<GuestDishes> GuestDishes { get; set; }
        public ICollection<ResturentDishes> ResturentDishes { get; set; }

        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
