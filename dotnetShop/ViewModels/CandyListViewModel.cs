using System;
using dotnetShop.Models;
using System.Collections.Generic;

namespace dotnetShop.ViewModels
{
    public class CandyListViewModel
    {
        public IEnumerable<Candy> Candies { get; set; }
        public string CurrentCategory { get; set; }

    }
}
