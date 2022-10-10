using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpUserClient : IHttpClient<User>
    {
        /// <summary>
        /// Get one user for your name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<User> GetByNameAsync(string name);

        /// <summary>
        /// get one user for your email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User> GetByEmailAsync(string email);

        /// <summary>
        /// Give access to app by email, name and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> AccessToAppAsync(string email, string password);

        /// <summary>
        /// If exist the email in the DB
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> ExistEmailAsync(string email);

        /// <summary>
        /// Decryp password by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<RecoveryPassword> RecoveryPasswordAsync(string email);

        /// <summary>
        /// Get all solutions by userId
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task<IEnumerable<Solution>> GetByUserAsync(Int32 usuario);
    }
}
