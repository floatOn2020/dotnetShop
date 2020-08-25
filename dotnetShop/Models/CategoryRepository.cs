using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnetShop.Models
{

    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        { 
            _appDbContext = appDbContext;
        }
    
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
            
        
            //new Category{CategoryId=1, CategoryName="Licorice", CategoryDescription="Best of Denmark"},
            //new Category{CategoryId=2, CategoryName="Chocolates", CategoryDescription="Blocks of Happiness"},
            //new Category{CategoryId=3, CategoryName="Fruit Candy", CategoryDescription="Like real fruit, just without nutrition value"}
    }
}
