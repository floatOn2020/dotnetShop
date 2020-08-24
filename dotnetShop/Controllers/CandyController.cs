using dotnetShop.Models;
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

        public ViewResult List()
        {
            return View(_candyRepository.GetAllCandy);
        }
    }
}
