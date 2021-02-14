using DapperCandyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCandyShop.Repositories.Interfaces
{
    public interface ICandy
    {
        List<Candy> GetCandies();
    }
}
