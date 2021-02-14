using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCandyShop.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(string s);
        bool Add(T Entity, string s);
        bool Update(T Entity, string s);
        bool Delete(T Entity, string s);
    }
}
