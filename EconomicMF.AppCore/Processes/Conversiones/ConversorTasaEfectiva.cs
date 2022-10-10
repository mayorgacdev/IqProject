using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Conversiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes.Conversiones
{
    //cuando es anual 
    public class ConversorTasaEfectiva : IConversor
    {

        public decimal Convertir(ConversionDto conversion)
        {
            //nominal
            if (conversion.TipoActual.Equals(TipoTasa.Nominal))
            {
                if (!conversion.FrecCapActual.Equals(FrecuenciaTasa.AnualCapContinuamente))
                {
                    return ConvertEffectiveToNominal(conversion.TasaOriginal, conversion.CapitalizacionActual);
                }
                return ConvertEffectiveToContinous(conversion.TasaOriginal);
            }
            //efectiva periodica
            int cap = (int)Enum.Parse(typeof(Periodo), conversion.FrecCapActual.ToString());
            return ConvertEffectiveToPeriodic(conversion.TasaOriginal, cap);
        }
        public decimal ConvertEffectiveToNominal(decimal tasa, int capitalizacion)
        {
            double raiz = (double)(Math.Pow((1 + (double)tasa), (1 / (double)capitalizacion)));
            return (decimal)(raiz - 1) * capitalizacion;
        }
        public decimal ConvertEffectiveToContinous(decimal tasa)
        {
            return (decimal)Math.Log(1 + (double)tasa);
        }
        public decimal ConvertEffectiveToPeriodic(decimal tasa, int capitalizacion)
        {
            decimal tasaIntermedia = ConvertEffectiveToNominal(tasa, capitalizacion);
            return new ConversorTasaNominal().ConvertNominalToPeriodic(tasaIntermedia, capitalizacion);
        }
    }
}
