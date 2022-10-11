using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using EconomicMF.Domain.Entities.Flows;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpProjectEntryClient : IHttpClient<ProjectEntry>
    {


        /// <summary>
        /// Set many entries to one project
        /// </summary>
        /// <param name="ingresoProyectos"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<bool> SetEntriesAsync(ProjectEntry ingresoProyectos);

        /// <summary>
        /// Get entries by project id
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<List<ProjectEntry>> GetEntriesAsync(Int32 projectId);
    }
}
