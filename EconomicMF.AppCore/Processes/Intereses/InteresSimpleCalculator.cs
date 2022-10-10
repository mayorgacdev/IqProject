using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes.Intereses
{
    public class InteresSimpleCalculator : IRateCalculator
    {

        public decimal CalcularVF(RateDto interes)
        {
            return Math.Round((decimal)(interes.ValorPresente * (1 + interes.TasaInteres * interes.NumPeriodos)), 2);
        }

        public decimal CalcularTiempo(RateDto interes)
        {
            return Math.Round((decimal)(((interes.ValorFuturo / interes.ValorPresente) - 1) / interes.TasaInteres), 2);
        }

        public decimal CalcularVP(RateDto interes)
        {
            return Math.Round((decimal)(interes.ValorFuturo / (1 + interes.TasaInteres * interes.NumPeriodos)), 2);
        }

        public decimal CalcularTasa(RateDto interes)
        {
            return Math.Round((decimal)(((interes.ValorFuturo / interes.ValorPresente) - 1) / interes.NumPeriodos), 2);
        }
    }
}
