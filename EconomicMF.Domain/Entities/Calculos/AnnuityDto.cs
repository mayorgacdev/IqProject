using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Calculos
{
    public class AnnuityDto
    //public class AnnuityDto : EconomicDto
    {
        public int Id { get; set; }
        public int IdSolution { get; set; }
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal NumPeriodos { get; set; }
        public decimal PagoAnual { get; set; }
        public TipoAnualidad TipoAnualidad { get; set; }
        public decimal PeriodoGracia { get; set; }
        public Periodo Periodo { get; set; }
        public decimal Crecimiento { get; set; }
        public TipoCrecimiento TipoDeCrecimiento { get; set; }
        public decimal FuturoGradiente { get; set; }
    }
}
