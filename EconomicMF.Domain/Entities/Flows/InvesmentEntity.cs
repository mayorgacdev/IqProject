﻿using EconomicMF.Domain.Enums.Others;
using System;

namespace EconomicMF.Domain.Entities.Flows
{
    public partial class InvesmentEntity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool IsPorcentage { get; set; }
        public decimal Contribution { get; set; }
        public decimal Rate { get; set; }
        public string TipoDeAmortización { get; set; } = String.Empty;
        public bool MoneyLoan { get; set; }
        public bool FeeLevel { get; set; }
        public int LoanTerm { get; set; }
    }
}
