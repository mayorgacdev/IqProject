using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes.Intereses
{
    public class InteresNominalCalculator : IRateCalculator
    {
        public decimal CalcularVF(RateDto interes)
        {
            if (interes.FrecuenciaTasa.Equals(FrecuenciaTasa.AnualCapContinuamente))
            {
                //F = P*e^(j*n)
                double valor = (double)interes.PresentValue * Math.Pow(Math.E, (double)(interes.TasaInteres * interes.NumPeriodos));
                return (decimal)Math.Round(valor,2);
            }
            double factor = (double)(1 + interes.TasaInteres / interes.Capitalizacion);
            return Math.Round((decimal)(interes.PresentValue * (decimal)Math.Pow(factor, (double)interes.NumPeriodos * interes.Capitalizacion)), 2);
        }

        public decimal CalcularTiempo(RateDto interes)
        {
            if (interes.FrecuenciaTasa.Equals(FrecuenciaTasa.AnualCapContinuamente))
            {
                //n = (ln(F) - ln(P)) / j
                double valor = (Math.Log((double)interes.FutureValue) - Math.Log((double)interes.PresentValue)) / (double)interes.TasaInteres;
                return (decimal)Math.Round(valor, 2);
            }
            double numerador = (double)(interes.FutureValue / interes.PresentValue);
            double denominador = (double)(1 + interes.TasaInteres / interes.Capitalizacion);
            return Math.Round((decimal)(Math.Log(numerador) / (interes.Capitalizacion * Math.Log(denominador))), 2);
        }

        public decimal CalcularVP(RateDto interes)
        {
            if (interes.FrecuenciaTasa.Equals(FrecuenciaTasa.AnualCapContinuamente))
            {
                //P = F / (e ^ (j * n))
                double valor = (double)interes.FutureValue / Math.Pow(Math.E, (double)(interes.TasaInteres * interes.NumPeriodos));
                return (decimal)Math.Round(valor, 2);
            }
            double factor = (double)(1 + interes.TasaInteres / interes.Capitalizacion);
            return Math.Round((decimal)(interes.FutureValue * (decimal)Math.Pow(factor, (double)interes.NumPeriodos * -1 * interes.Capitalizacion)), 2);
        }

        public decimal CalcularTasa(RateDto interes)
        {
            if (interes.FrecuenciaTasa.Equals(FrecuenciaTasa.AnualCapContinuamente))
            {
                //j = (ln(F) - ln(P))/ n
                double value = (Math.Log((double)interes.FutureValue) - Math.Log((double)interes.PresentValue)) / (double)interes.NumPeriodos;
                return (decimal)Math.Round(value, 2);
            }
            double raiz = (double)(interes.NumPeriodos * interes.Capitalizacion);
            double valor = Math.Pow((double)(interes.FutureValue / interes.PresentValue), 1 / raiz);
            return Math.Round((decimal)(interes.Capitalizacion * (valor - 1)),2);
        }
    }
}
