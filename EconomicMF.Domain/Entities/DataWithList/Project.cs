using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;

namespace EconomicMF.Domain.Entities.DataWithList
{
    public class Project
    {
        public int Id { get; set; }
        public int SolutionId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; }
        public string Period { get; set; } = String.Empty;
        public int Duration { get; set; }
        public bool WithFinancing { get; set; }
        public decimal TMAR { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal TMARMixta { get; set; }
        public decimal Contribution { get; set; }
        public decimal RecoveryCt { get; set; }
        public virtual Solution Solution { get; set; } = null!;
        public virtual List<InvesmentArea> InvestmentArea { get; set; }
        public virtual List<ProjectCost> ProjectCosts { get; set; }
        public virtual List<InvesmentEntity> InvestmentEntities { get; set; }
        public virtual List<ProjectExpense> ProjectExpenses { get; set; }
        public virtual List<ProjectEntry> ProjectEntries { get; set; }
        public virtual List<Asset> Assets { get; set; }
    }
}
