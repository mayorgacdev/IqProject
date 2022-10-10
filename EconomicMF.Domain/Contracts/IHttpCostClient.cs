using EconomicMF.Domain.Entities.Flows;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpCostClient : IHttpClient<ProjectCost>
    {
        /// <summary>
        /// Add many costProjects to Project
        /// </summary>
        /// <param name="costProjects"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<bool> SetCost(ProjectCost costProjects);

        /// <summary>
        /// Get all the projectCost by ProjectId
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IEnumerable<ProjectCost>> GetAllCost(Int32 projectId);
    }
}
