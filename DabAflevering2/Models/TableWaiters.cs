using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DabAflevering2.Models
{
    public class TableWaiters
    {
        
        public Waiter Waiter { get; set; }
        public int PersonId { get; set; }
        public Table Table { get; set; }
        public int TableId { get; set; }
    }
}
