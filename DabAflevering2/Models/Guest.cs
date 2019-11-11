using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DabAflevering2.Models
{
    public class Guest : Person
    {
       // public DateTime Time { get; set; }

        //Navigation properties
        
        public int TableId { get; set; }
        public Table Table { get; set; }
       
        public int? ReviewId { get; set; }
        public Review Review { get; set; }


        public ICollection<GuestDishes> guestDishes { get; set; }

        [NotMapped]
        public ICollection<Review> Reviews { get; set; }
    }
}
