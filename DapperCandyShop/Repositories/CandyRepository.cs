using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using DapperCandyShop.Repositories.Interfaces;
using DapperCandyShop.Models;

namespace DapperCandyShop.Repositories
{
    public class CandyRepository : ICandy
    {
        private readonly IConfiguration _config;

        public CandyRepository(IConfiguration config)
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

        public List<Candy> GetCandies()
        {
            using (IDbConnection conn = dbConnection)
            {
                string sql = "SELECT Name FROM Candy;";
                conn.Open();
                var results = conn.Query<Candy>(sql).ToList();
                conn.Close();
                return results;
            }
        }
               
    }
}
