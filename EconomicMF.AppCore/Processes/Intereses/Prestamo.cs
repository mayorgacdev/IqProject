using EconomicMF.Domain.Enums.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Services.Processes.Intereses
{
    public class Prestamo
    {
        public Guid Guid { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public decimal Monto { get; set; }
        public double Interes { get; set; }
        public string TipoDeAmortizacion { get; set; }

        public Prestamo()
        {
            Guid = Guid.NewGuid();
        }
    }
}
