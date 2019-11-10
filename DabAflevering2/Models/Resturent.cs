using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DabAflevering2.Models
{
    public class Resturent 
    {
        //Attributes
        public int ResturentId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //NavigationProberties
        public ICollection<ResturentDishes> ResturentDishes { get; set; }
        public ICollection<Table> Tables { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
