using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LemonPieShop.Models
{
    public interface ICategoriesRepository
    {
        IEnumerable<Category> AllCategories
        {
            get;
        }
    }
}
