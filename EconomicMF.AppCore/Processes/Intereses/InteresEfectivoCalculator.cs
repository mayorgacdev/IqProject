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
            return Math.Round((decimal)(interes.ValorPresente * (decimal)Math.Pow(factor, (double)interes.NumPeriodos)),2);
        }

        public decimal CalcularTiempo(RateDto interes)
        {
            double numerador = (double)(interes.ValorFuturo / interes.ValorPresente);
            double denominador = (double)(1 + interes.TasaInteres);
            return Math.Round((decimal)(Math.Log(numerador) / Math.Log(denominador)),2);
        }

        public decimal CalcularVP(RateDto interes)
        {
            double factor = (double)(1 + interes.TasaInteres);
            return Math.Round((decimal)((double)interes.ValorFuturo / Math.Pow(factor, (double)interes.NumPeriodos)), 2);
        }

        public decimal CalcularTasa(RateDto interes)
        {
            double factor = (double)(interes.ValorFuturo / interes.ValorPresente);
            return Math.Round((decimal)Math.Pow(factor, (1 / (double)interes.NumPeriodos)) - 1,2);
        }
    }
}
