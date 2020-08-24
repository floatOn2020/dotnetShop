using System;
using System.Collections.Generic;

namespace dotnetShop.Models
{
    public interface ICandyRepository
    {
       IEnumerable<Candy> GetAllCandy { get; }
       IEnumerable<Candy> GetCandyOnSale { get; }
       Candy GetCandyById(int candyId);
    }
}
