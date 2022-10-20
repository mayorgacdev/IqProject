using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes.Anualidades
{
    public class AnualidadPerpCalculator : IAnualidadCalculator
    {
        public decimal CalcularPago(AnnuityDto anualidad)
        {
            //return anualidad.ValorPresente * anualidad.TasaInteres;
            return Math.Round(anualidad.PresentValue * anualidad.TasaInteres,4);
        }

        public decimal CalcularTasa(AnnuityDto anualidad)
        {
            //return anualidad.PagoAnual / anualidad.ValorPresente * 100;
            return Math.Round(anualidad.PagoAnual / anualidad.PresentValue * 100,4);
        }

        public decimal CalcularTiempo(AnnuityDto anualidad)
        {
            //return decimal.MaxValue;
            return 99999999;
        }

        public decimal CalcularVF(AnnuityDto anualidad)
        {
            //return decimal.MaxValue;
            return 99999999;
        }

        public decimal CalcularVP(AnnuityDto anualidad)
        {
            //return anualidad.PagoAnual / anualidad.TasaInteres;
            return Math.Round(anualidad.PagoAnual / anualidad.TasaInteres,4);
        }
        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            return 0;
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            return 0;
        }
    }
}
