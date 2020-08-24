using System;
using System.Collections.Generic;

namespace dotnetShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
