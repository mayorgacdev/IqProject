using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Calculos
{
    public class FlujoDeCaja
    {
        public int Id { get; set; }
        public  List<EconomicDto> FlujoEfectivo { get; set; }
        public decimal VP { get; set; }
        public decimal VF { get; set; }
        public decimal Tasa { get; set; }
        public int NPer { get; set; }
    }
}
