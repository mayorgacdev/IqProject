﻿namespace EconomicMF.Helper
{
    public class AssetOther
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountResidual { get; set; }
        public int Terms { get; set; }
        public string DepreciationRate { get; set; }
        public string Code { get; set; }
        public bool AñosDeDepreciaciónSegunNi { get; set; }
        public string Status { get; set; }
        public bool IsDepreciable { get; set; }
    }
}
