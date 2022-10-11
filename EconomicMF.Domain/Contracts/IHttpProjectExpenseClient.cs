using EconomicMF.Domain.Entities.Flows;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace EconomicMF.Domain.Contracts
{
    public interface IHttpProjectExpenseClient : IHttpClient<ProjectExpense>
    {
        /// <summary>
        /// Add many projectExpense to Project with the Id
        /// </summary>
        /// <param name="gastoProjects"></param>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<bool> SetExpense(ProjectExpense gastoProjects);

        /// <summary>
        /// Get all the expenses
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<List<ProjectExpense>> GetAllExpenses(Int32 projectId);
    }
}
