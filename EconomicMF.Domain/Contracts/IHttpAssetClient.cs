using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using EconomicMF.Domain.Entities.Flows;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpAssetClient : IHttpClient<Asset>
    {
        /// <summary>
        /// Set one Asset async 
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        Task<bool> SetAssetAsync(Asset asset);

        /// <summary>
        /// Get all the Asset by ProjectId
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IEnumerable<Asset>> GetAllAssetAsync(Int32 projectId);
    }
}
