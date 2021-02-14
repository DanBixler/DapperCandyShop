using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DapperCandyShop.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using Dapper;

namespace DapperCandyShop.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IConfiguration _config;

        public Repository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection dbConnection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public IEnumerable<TEntity> Get(string s)
        {
            using (IDbConnection conn = dbConnection)
            {
                conn.Open();
                var result = conn.Query<TEntity>(s);
                conn.Close();
                return result;
            }
        }

        public bool Add(TEntity entity, string s)
        {
            using (IDbConnection conn = dbConnection)
            {
                conn.Open();
                int result = conn.Execute(s, param: entity);
                conn.Close();
                if (result != 0)
                {
                    return true;
                }    
                else
                {
                    return false;
                }
            }
        }

        public bool Update(TEntity entity, string s)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity, string s)
        {
            throw new NotImplementedException();
        }
    }
}
