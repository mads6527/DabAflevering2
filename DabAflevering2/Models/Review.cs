using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DabAflevering2.Models
{
    public class Review 
    {
        //attributes
        public int ReviewId { get; set; }
        public int Stars { get; set; }
        public string Text { get; set; }

        //Navigation properties
        public int ResturentId { get; set; }
        public Resturent Resturent { get; set; }

        public ICollection<Dish> Dishes { get; set; }
        public ICollection<Guest> Guests { get; set; }  
    }
}
