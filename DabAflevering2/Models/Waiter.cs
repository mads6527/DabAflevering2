using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DabAflevering2.Models
{
    public class Waiter : Person
    {
        public double Salery { get; set; }

        //navigation propterties
        public ICollection<TableWaiters> TableWaiters { get; set; }
    }
}
