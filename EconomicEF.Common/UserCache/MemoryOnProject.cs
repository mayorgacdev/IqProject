using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;

namespace EconomicEF.Common.UserCache
{
    public static class MemoryOnProject
    {
        public static decimal TMAR { get; set; }
        public static int LoanTerm { get; set; }
        public static decimal Contribution { get; set; }
        public static decimal TmarMixta { get; set; }
        public static List<decimal> CalculoTmar { get; set; } = new List<decimal>();
        public static Guid Guid { get; set; }
        public static Guid Forgot { get; set; }
    }
}
