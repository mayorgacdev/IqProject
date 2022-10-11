using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using EconomicMF.Domain.Entities.Flows;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpInvesmentAreaClient : IHttpClient<InvesmentArea>
    {
        /// <summary>
        /// Set many invesmentArea to Project
        /// </summary>
        /// <param name="inversionProyectos"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<bool> SetInvesmentArea(InvesmentArea inversionProyectos);

        /// <summary>
        /// Get All the invesmentArea Related to projectId
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<List<InvesmentArea>> GetProjects(Int32 projectId);
    }
}
