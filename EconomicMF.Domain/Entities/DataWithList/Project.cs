using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
        public virtual Solution Solution { get; set; } = new Solution();
        public virtual List<InvesmentArea> InvestmentArea { get; set; } = new List<InvesmentArea>();
        public virtual List<ProjectCost> ProjectCosts { get; set; } = new List<ProjectCost>();
        public virtual List<InvesmentEntity> InvestmentEntities { get; set; } = new List<InvesmentEntity>();
        public virtual List<ProjectExpense> ProjectExpenses { get; set; } = new List<ProjectExpense>();
        public virtual List<ProjectEntry> ProjectEntries { get; set; } = new List<ProjectEntry>();
        public virtual List<Asset> Assets { get; set; } = new List<Asset>();
    }
}
