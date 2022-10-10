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
        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularPago(AnnuityDto anualidad)
        {
            //return anualidad.ValorPresente * anualidad.TasaInteres;
            return Math.Round(anualidad.ValorPresente * anualidad.TasaInteres,2);
        }

        public decimal CalcularTasa(AnnuityDto anualidad)
        {
            //return anualidad.PagoAnual / anualidad.ValorPresente * 100;
            return Math.Round(anualidad.PagoAnual / anualidad.ValorPresente * 100,2);
        }

        public decimal CalcularTiempo(AnnuityDto anualidad)
        {
            //return decimal.MaxValue;
            return Math.Round(decimal.MaxValue,2);
        }

        public decimal CalcularVF(AnnuityDto anualidad)
        {
            //return decimal.MaxValue;
            return Math.Round(decimal.MaxValue,2);
        }

        public decimal CalcularVP(AnnuityDto anualidad)
        {
            //return anualidad.PagoAnual / anualidad.TasaInteres;
            return Math.Round(anualidad.PagoAnual / anualidad.TasaInteres,2);
        }
    }
}
