using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.FlowTool
{
    public class DLR
    {
        public int Período { get; set; }
        public decimal DepreciaciónPorPeríodo { get; set; }
        public decimal DepreciaciónAcumulada { get; set; }
        public decimal valorLibros { get; set; }
    }
}
