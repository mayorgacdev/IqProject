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
    //cuando es semestral, cuatrimestral, tremestral, etc, menos anual 
    public class ConversorTasaPeriodica : IConversor
    {

        public decimal Convertir(ConversionDto conversion)
        {
            int cap;
            //nominal
            if (conversion.TipoActual.Equals(TipoTasa.Nominal))
            {
                cap = (int)Enum.Parse(typeof(Periodo), conversion.FrecCapOriginal.ToString());
                decimal tasa = ConvertPeriodicToNominal(conversion.TasaOriginal, cap);
                if (conversion.CapitalizacionActual != cap)
                {
                    tasa = new ConversorTasaNominal().ConvertNominalToNominal(tasa, cap, conversion.CapitalizacionActual);
                }
                return tasa;
            }
            //efectiva anual
            cap = (int)Enum.Parse(typeof(Periodo), conversion.FrecCapOriginal.ToString());
            return ConvertPeriodicToEffective(conversion.TasaOriginal, cap);
        }

        public decimal ConvertPeriodicToNominal(decimal tasa, int capitalizacion)
        {
            return capitalizacion * tasa;
        }
        public decimal ConvertPeriodicToEffective(decimal tasa, int capitalizacion)
        {
            decimal tasaIntermedia = ConvertPeriodicToNominal(tasa, capitalizacion);
            return new ConversorTasaNominal().ConvertNominalToEffective(tasaIntermedia, capitalizacion);
        }
    }
}
