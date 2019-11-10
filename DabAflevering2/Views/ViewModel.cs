using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DabAflevering2.Models;

namespace DabAflevering2.Views
{
    public class ViewModel
    {
        public string _resturentname;
        public int _average;
        public ICollection<Review> _reviews;
        public string _type;
    }
}
