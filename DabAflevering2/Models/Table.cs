using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DabAflevering2.Models
{
    public class Table : IEntity
    {
        //Attributes
        public int TableId { get; set; }
        public int Number { get; set; }

        //Navigation properties
        public int ResturentId { get; set; }
        public Resturent Resturent { get; set; }
        
        public ICollection<TableWaiters> TableWaiters { get; set; }
        public ICollection<Guest> Guests { get; set; }
    }
}
