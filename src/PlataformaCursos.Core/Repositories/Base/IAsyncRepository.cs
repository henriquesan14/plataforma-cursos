﻿using PlataformaCursos.Core.Entities;
using System.Linq.Expressions;

namespace PlataformaCursos.Core.Repositories.Base
{
    public interface IAsyncRepository<T> where T : EntityBase
    {
        Task<IReadOnlyList<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
          string includeString = null,
          bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
          List<Expression<Func<T, object>>> includes = null,
          bool disableTracking = true,
          int? pageNumber = null, int? pageSize = 20);

        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(int id, List<Expression<Func<T, object>>> includes = null);

        Task<T> AddAsync(T entity);

        Task AddRangeAsync(List<T> entity);

        void UpdateAsync(T entity);

        void DeleteAsync(T entity);
        Task<int> GetCountAsync(Expression<Func<T, bool>> predicate = null);
    }
}
