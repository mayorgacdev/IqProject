using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Conversiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Calculos
{
    public class RateDto
    //public class RateDto : EconomicDto
    {
        public int Id { get; set; }
        public int IdSolution { get; set; }
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal NumPeriodos { get; set; }
        public TipoInteres TipoInteres { get; set; }
        public FrecuenciaTasa FrecuenciaTasa { get; set; }
        //public int Capitalizacion { get; set; }

        //se puede ocultar esta capitalizacion
        //public int Capitalizacion => (int)FrecuenciaTasa;

        //TODO: Ocultamiento de Capitalizacion
        public int Capitalizacion => GetCapitalizacion();
        private int GetCapitalizacion()
        {
            if (TipoInteres.Equals(TipoInteres.CompuestoConTasaEfectiva) || TipoInteres.Equals(TipoInteres.Simple))
            {
                return 1;
            }
            string nombre = FrecuenciaTasa.ToString();
            return (int)Enum.Parse(typeof(FrecTasaNom), nombre);
        }
    }
}
