using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LemonPieShop.Models;
using LemonPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LemonPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoriesRepository _categoriesRepository;

        public PieController(IPieRepository pieRepository, ICategoriesRepository categoriesRepository)
        {
             _pieRepository = pieRepository;
            _categoriesRepository = categoriesRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }

    }
}
