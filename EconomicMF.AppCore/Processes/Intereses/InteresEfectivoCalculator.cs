using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes.Intereses
{
    public class InteresEfectivoCalculator : IRateCalculator
    {
        public decimal CalcularVF(RateDto interes)
        {
            double factor = (double)(1 + interes.TasaInteres);
            return Math.Round((decimal)(interes.PresentValue * (decimal)Math.Pow(factor, (double)interes.NumPeriodos)),2);
        }

        public decimal CalcularTiempo(RateDto interes)
        {
            double numerador = (double)(interes.FutureValue / interes.PresentValue);
            double denominador = (double)(1 + interes.TasaInteres);
            return Math.Round((decimal)(Math.Log(numerador) / Math.Log(denominador)),2);
        }

        public decimal CalcularVP(RateDto interes)
        {
            double factor = (double)(1 + interes.TasaInteres);
            return Math.Round((decimal)((double)interes.FutureValue / Math.Pow(factor, (double)interes.NumPeriodos)), 2);
        }

        public decimal CalcularTasa(RateDto interes)
        {
            double factor = (double)(interes.FutureValue / interes.PresentValue);
            return Math.Round((decimal)Math.Pow(factor, (1 / (double)interes.NumPeriodos)) - 1,2);
        }
    }
}
