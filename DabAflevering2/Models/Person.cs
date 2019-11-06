using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DabAflevering2.Models
{
    public class Person : IEntity
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
    }
}
