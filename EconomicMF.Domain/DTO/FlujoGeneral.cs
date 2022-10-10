using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.DTO
{
    public class FlujoGeneral
    {
        public int Id { get; set; }
        public List<CostoGeneral> costoGenerals { get; set; }
        public List<IngresosGeneral> ingresosGenerals { get; set; }
        public List<ActivosGeneral> activosGenerals { get; set; }
        public List<GastosGeneral> gastosGenerals { get; set; }
        public List<PrestamosGeneral> prestamosGenereals { get; set; }
    }
    public class CostoGeneral
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<decimal> Monto { get; set; }
    }
    public class IngresosGeneral
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<decimal> Monto { get; set; }
    }
    public class ActivosGeneral
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal ValorResidual { get; set; }
        public List<decimal> Monto { get; set; }
    }
    public class GastosGeneral
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<decimal> Monto { get; set; }
    }
    public class PrestamosGeneral
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<decimal> Interes { get; set; }
        public List<decimal> AbonoDeuda { get; set; }
        public List<decimal> SaldoInsoluto { get; set; }
    }
}
