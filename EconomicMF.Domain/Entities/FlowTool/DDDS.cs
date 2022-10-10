using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.FlowTool
{
    public class DDDS
    {
        public int Período { get; set; }
        public string Tasa { get; set; }
        public decimal DepreciaciónPorPeríodo { get; set; }
        public decimal ValorLibro { get; set; }
    }
}
