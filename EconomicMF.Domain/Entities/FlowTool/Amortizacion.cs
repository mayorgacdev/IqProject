namespace EconomicMF.Domain.Entities.FlowTool
{
    public class Amortizacion
    {
        public int Período { get; set; }
        public decimal AbonoDeuda { get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        public decimal SaldoInsoluto { get; set; }
    }
}
