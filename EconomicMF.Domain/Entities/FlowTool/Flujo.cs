namespace EconomicMF.Domain.Entities.FlowTool
{
    public partial class Flujo
    {
        public int Id { get; set; }
        public int Concepto { get; set; }
        public decimal IngresosNetos { get; set; }
        public decimal CostosNetos { get; set; }
        public decimal GastosNetos { get; set; }
        public decimal InterésesNetos { get; set; }
        public decimal Depreciación { get; set; }
        public decimal Amortización { get; set; }
        public decimal Utilidad_antes_de_IR { get; set; }
        public decimal IR { get; set; }
        public decimal Utilidad_después_de_IR { get; set; }
        public decimal Depreciación_ { get; set; }
        public decimal Amortización_ { get; set; }
        public decimal? ValorResidual { get; set; }
        public decimal Recuperación_de_capital_de_Trabajo { get; set; }
        public decimal PrestamosNetos { get; set; }
        public decimal Inversion { get; set; }
        public decimal Abono_a_la_deuda { get; set; }
        public decimal? FNE { get; set; }
        public decimal FNE_Acumulado { get; set; }
        //  public virtual Project IdProjectNavigation { get; set; }
    }
}
