using EconomicMF.Domain.DTO;
using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpIInvesmentEntityClient : IHttpClient<InvesmentEntity>
    {
        /// <summary>
        /// Get All the invesment by projectId
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IEnumerable<InvesmentEntity>> GetByProjectIdAsync(int projectId);
        /// <summary>
        /// Get All the entities by SolutionId
        /// </summary>
        /// <param name="solutionId"></param>
        /// <returns></returns>
        Task<IEnumerable<InvesmentEntity>> GetBySolutionIdAsync(int solutionId);

        /// <summary>
        /// Get one invesment by projectId
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<InvesmentEntity> GetOneInvesmentAsync(int projectId);

        /// <summary>
        /// Add one Invesment Entity to project
        /// </summary>
        /// <param name="entidadInvs"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<bool> SetInvesmentEntityAsync(InvesmentEntity entidadInvs);

        /// <summary>
        /// Get Uniques names of the invesment
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IEnumerable<HasTrabajadoCon>> GetUniqueNames(int solutionId);
    }
}
