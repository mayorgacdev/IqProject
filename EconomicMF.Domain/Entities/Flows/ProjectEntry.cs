﻿namespace EconomicMF.Domain.Entities.Flows
{
    public partial class ProjectEntry
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public decimal Entry { get; set; }
        public decimal Growth { get; set; }
        public string? TypeGrowth { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public string EntryType { get; set; }
    }
}
