﻿using System;

namespace EconomicMF.Domain.Entities.Flows
{
    public partial class ProjectClient
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
    }
}
