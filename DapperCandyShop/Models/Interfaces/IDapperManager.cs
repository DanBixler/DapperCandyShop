using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.Common;

namespace DapperCandyShop.Models
{
    public interface IDapperManager : IDisposable
    {
        DbConnection GetConnection();
        T Get<T>(string storedProc, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string storedProc, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    }
}
