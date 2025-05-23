﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Query();
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T> GetByIdAsync(Guid id);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task AddRangeAsync(T entity);
        Task RealAddRangeAsync(IEnumerable<T> entity);
        Task RealUpdateRangeAsync(IEnumerable<T> entity);
        Task DetachedAndUpdateAsync(T entity);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(T entity);
        Task DeleteAsync(int id);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T obj);
    }

}
