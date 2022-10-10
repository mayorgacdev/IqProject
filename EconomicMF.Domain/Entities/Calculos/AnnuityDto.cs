using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Calculos
{
    public class AnnuityDto : EconomicDto
    {
        public decimal PagoAnual { get; set; }
        public TipoAnualidad TipoAnualidad { get; set; }
        public int PeriodoGracia { get; set; }
        public Periodo Periodo { get; set; }
        public decimal Crecimiento { get; set; }
        public TipoCrecimiento TipoDeCrecimiento { get; set; }
        public decimal FuturoGradiente { get; set; }
    }
}
