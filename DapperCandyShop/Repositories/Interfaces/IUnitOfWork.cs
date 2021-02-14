using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCandyShop.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : IConfiguration
    {
        TContext Context { get; }
    }
}
