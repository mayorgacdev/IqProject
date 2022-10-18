using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Calculos
{
    //se quito el abstracto
    public  class EconomicDto
    {
        //TODO: Economic primera version, para que se pueda heredar 
        //public int Id { get; set; }
        //public int IdSolution { get; set; }
        ////TODO: revisar discriminador 
        //public string Discriminator { get; set; } = null!;
        //public int IdUser { get; set; }
        //public decimal PresentValue { get; set; }
        //public decimal FutureValue { get; set; }
        //public decimal TasaInteres { get; set; }
        //public decimal NumPeriodos { get; set; }

        //public UserDto Usuario { get; set; }

        //TODO: Segunda version de economic, con todas las propiedades 
        public int Id { get; set; }
        public int SolutionId { get; set; }
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal NumPeriodos { get; set; }
        public string Discriminator { get; set; } = null!;
        public decimal? PagoAnual { get; set; }
        public TipoAnualidad TipoAnualidad { get; set; }
        public int PeriodoGracia { get; set; }
        public Periodo Periodo { get; set; }
        public TipoInteres TipoInteres { get; set; }
        public FrecuenciaTasa FrecuenciaTasa { get; set; }
        public decimal? Crecimiento { get; set; }
        public decimal? FuturoGradiente { get; set; }
        public TipoCrecimiento TipoDeCrecimiento { get; set; }

    }
}
