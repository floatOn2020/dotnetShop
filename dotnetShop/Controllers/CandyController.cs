using dotnetShop.Models;
using dotnetShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
namespace dotnetShop.Controllers
{

    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "Bestsellers";
            return View(candyListViewModel);
        }

        public IActionResult Details(int id)
        {
            var candy = _candyRepository.GetCandyById(id);
            if (candy == null)
                return NotFound();
            return View(candy);
        }

    }
}
