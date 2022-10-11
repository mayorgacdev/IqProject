using EconomicMF.Domain.Contracts.CalculosRepositories;
using System;

namespace EconomicMF.Domain.Contracts
{
    public interface IUnitOfWork
    {
        IHttpConversionClient ConversionClient { get; }
        IHttpEconomicClient EconomicClient { get; }
        IHttpCostClient CostClient { get; }
        IHttpIInvesmentEntityClient InvesmentEntityClient { get; } 
        IHttpInvesmentAreaClient InvesmentArea { get; }
        IHttpProjectClient ProjectClient { get; }
        IHttpProjectExpenseClient ProjectExpense { get; }
        IHttpProjectEntryClient ProjectEntryClient { get; }
        IHttpSolutionClient SolutionClient { get; }
        IHttpUserClient UserClient { get; }
        IMailRepository MailClient { get; }
        IHttpAssetClient AssetClient { get; }

    }
}
