using LemonPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LemonPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie>  PiesOfTheWeek { get; set; }

    }
}
