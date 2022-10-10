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
    //cuando es capitalizable
    public class ConversorTasaNominal : IConversor
    {
        public decimal Convertir(ConversionDto conversion)
        {
            //nominal
            if (conversion.TipoActual.Equals(TipoTasa.Nominal))
            {
                return ConvertNominalToNominal(conversion.TasaOriginal, conversion.CapitalizacionOriginal, conversion.CapitalizacionActual);
            }
            //efectiva periodica
            else if (conversion.TipoActual.Equals(TipoTasa.Efectiva) && !conversion.FrecCapActual.Equals(FrecuenciaTasa.Anual))
            {
                int cap = (int)Enum.Parse(typeof(Periodo), conversion.FrecCapActual.ToString());
                decimal tasa = conversion.TasaOriginal;
                if (cap != conversion.CapitalizacionOriginal)
                {
                    tasa = ConvertNominalToNominal(conversion.TasaOriginal, conversion.CapitalizacionOriginal, cap);
                }
                return ConvertNominalToPeriodic(tasa, cap);
            }
            //efectiva anual
            else
            {
                if (conversion.FrecCapOriginal != FrecuenciaTasa.AnualCapContinuamente)
                {
                    return ConvertNominalToEffective(conversion.TasaOriginal, conversion.CapitalizacionOriginal);
                }
                return ConvertContinousToEffective(conversion.TasaOriginal);
            }
        }
        public decimal ConvertNominalToPeriodic(decimal tasa, int capitalizacion)
        {
            return tasa / capitalizacion;
        }
        public decimal ConvertNominalToEffective(decimal tasa, int capitalizacon)
        {
            double suma = (double)(1 + (tasa / capitalizacon));
            return (decimal)(Math.Pow(suma, capitalizacon) - 1);
        }
        public decimal ConvertNominalToNominal(decimal tasa1, int capitalizacion1, int capitalizacion2)
        {
            double suma = (double)(1 + (double)tasa1 / capitalizacion1);
            double exponente = (double)capitalizacion1 / capitalizacion2;
            double raiz = Math.Pow(suma, exponente);
            return (decimal)(raiz - 1) * capitalizacion2;
        }
        private decimal ConvertContinousToEffective(decimal tasaNominal)
        {
            return (decimal)Math.Pow(Math.E, (double)tasaNominal) - 1;
        }
    }
}
