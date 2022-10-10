using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpClient<TEntity> where TEntity : class
    {

        /// <summary>
        /// You can create any entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> CreateAsync(TEntity entity);

        /// <summary>
        /// Update any Entity async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(TEntity entity);

        /// <summary>
        /// Get entity by Id (int)
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        Task<TEntity> GetAsync(Int32 guid);

        /// <summary>
        /// Remove any Entity from db
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(Int32 guid);

        /// <summary>
        /// Get all the entity from db
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Delegate func expression for any query this method is not recommended
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> where);
    }
}
