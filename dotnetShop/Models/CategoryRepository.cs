using System;
using System.Collections.Generic;

namespace dotnetShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Licorice", CategoryDescription="Best of Denmark"},
            new Category{CategoryId=2, CategoryName="Chocolates", CategoryDescription="Blocks of Happiness"},
            new Category{CategoryId=3, CategoryName="Fruit Candy", CategoryDescription="Like real fruit, just without nutrition value"}
        };
    }
}
