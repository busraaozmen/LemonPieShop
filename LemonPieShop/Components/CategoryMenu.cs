using LemonPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LemonPieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoryMenu(ICategoriesRepository categoriesRepository)
        {
           _categoriesRepository = categoriesRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoriesRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
