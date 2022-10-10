using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.FlowTool
{
    public class DSDA
    {
        public int Período { get; set; }
        public string Fraccion { get; set; }
        public decimal CantidadDepreciableTotal { get; set; }
        public decimal DepreciaciónPorPeríodo { get; set; }
        public decimal ValorLibro { get; set; }
    }
}
