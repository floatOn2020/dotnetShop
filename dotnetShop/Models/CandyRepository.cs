using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
            new Candy {CandyId = 1, Name="Assorted Licorice", Price = 3.5M, Description="Soufflé croissant chupa chups cupcake brownie sweet roll biscuit cookie topping. Candy canes caramels jelly-o tart cookie. Lollipop apple pie jujubes jelly beans marshmallow chocolate bar chupa chups jelly beans.", Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80", IsInStock=true, IsOnSale=false, ImageThumbnailUrl="https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80" },
            new Candy {CandyId = 2, Name="Assorted Licorice", Price = 2.5M, Description="Ice cream candy fruitcake marzipan wafer carrot cake macaroon. Sugar plum powder lollipop cupcake pastry danish oat cake icing. Icing marzipan pastry caramels gummi bears gingerbread wafer toffee.", Category = _categoryRepository.GetAllCategories.ToList()[1], ImageUrl="https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", IsInStock=true, IsOnSale=false, ImageThumbnailUrl="https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60" },
            new Candy {CandyId = 3, Name="Assorted Licorice", Price = 4.5M, Description="Cake chupa chups cheesecake chupa chups donut. Topping chocolate bar danish. Jelly lollipop jelly gummi bears soufflé chocolate cake cake dessert. Bear claw pastry ice cream pastry topping jelly cotton candy fruitcake tart.", Category = _categoryRepository.GetAllCategories.ToList()[2], ImageUrl="https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", IsInStock=true, IsOnSale=false, ImageThumbnailUrl="https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60" }
        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();


        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}