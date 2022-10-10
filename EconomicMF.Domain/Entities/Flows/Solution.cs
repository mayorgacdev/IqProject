using EconomicMF.Domain.Entities.Others;
using System;
using System.Collections.Generic;

#nullable disable

namespace EconomicMF.Domain.Entities.Flows
{
    public class Solution
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SolutionName { get; set; } = String.Empty!;
        public string Description { get; set; } = String.Empty!;
        public DateTime Date { get; set; }
    }
}
