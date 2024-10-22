﻿using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Contracts.CalculosRepositories;

namespace EconomicEF.Infraestructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            ConversionClient = new HttpConversionClient();
            EconomicClient = new HttpEconomicClient();
            CostClient = new HttpCostProjectClient();
            InvesmentEntityClient = new HttpInvesmentEntityClient();
            InvesmentArea = new HttpInvesmentAreaClient();
            ProjectClient = new HttpProjectClient();
            ProjectExpense = new HttpProjectExpenseClient();
            ProjectEntryClient = new HttpProjectEntryClient();
            SolutionClient = new HttpSolutionClient();
            UserClient = new HttpUserClient();
            MailClient = new MailRepository();
            AssetClient = new HttpAssetClient();

            flujoClient = new HttpFlujoCajaClient();
            flujoDetalleClient = new HttpFlujoCajaDetalleClient();
        }
        public IHttpConversionClient ConversionClient { get; }

        public IHttpEconomicClient EconomicClient { get; }

        public IHttpCostClient CostClient { get; }

        public IHttpIInvesmentEntityClient InvesmentEntityClient { get; }

        public IHttpInvesmentAreaClient InvesmentArea { get; }

        public IHttpProjectClient ProjectClient { get; }

        public IHttpProjectExpenseClient ProjectExpense { get; }

        public IHttpProjectEntryClient ProjectEntryClient { get; }

        public IHttpSolutionClient SolutionClient { get; }

        public IHttpUserClient UserClient { get; }

        public IMailRepository MailClient { get; }

        public IHttpAssetClient AssetClient { get; }
        public IHttpFlujoDetalleClient flujoDetalleClient { get; }
        public IHttpFlujoClient flujoClient { get; }
    }
}
