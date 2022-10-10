using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.FlowTool
{
    public class Totales
    {
        public int Id { get; set; }
        public string NombreProjecto { get; set; }
        public int CantidadInversiones { get; set; }
        public int CantidadCostos { get; set; }
        public int CantidadIngresos { get; set; }
        public decimal TotalInversiones { get; set; }
        public decimal TotalCostos { get; set; }
        public decimal TotalIngresos { get; set; }

    }
}
