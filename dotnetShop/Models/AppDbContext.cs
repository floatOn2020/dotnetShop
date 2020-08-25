using Microsoft.EntityFrameworkCore
using System;
namespace dotnetShop.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
: base(options)
        {
        }

        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
