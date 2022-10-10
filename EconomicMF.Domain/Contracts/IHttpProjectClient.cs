using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Entities.FlowTool;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpProjectClient : IHttpClient<ProjectClient>
    {
        /// <summary>
        /// get the last id of project
        /// </summary>
        /// <returns></returns>
        Task<int> LastCreatedAsync();
        /// <summary>
        /// set one project to solution
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        Task<bool> SetProjectToSolution(ProjectClient project);

        /// <summary>
        /// Get projects by solution Id
        /// </summary>
        /// <param name="solution"></param>
        /// <returns></returns>
        Task<IEnumerable<ProjectClient>> GetProjectsAsync(Int32 solution);
    }
}
