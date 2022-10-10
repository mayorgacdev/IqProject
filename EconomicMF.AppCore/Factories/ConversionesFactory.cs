using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.AppCore.Processes.Conversiones;
using EconomicMF.Domain.Entities;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
//using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums.Conversiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Factories
{
    public static class ConversionesFactory
    {
        public static IConversor VerConversion(ConversionDto conversion)
        {
            switch (conversion.TipoOriginal)
            {
                case TipoTasa.Efectiva:
                    if (!conversion.FrecCapOriginal.Equals(FrecuenciaTasa.Anual))
                    {
                        return new ConversorTasaPeriodica();
                    }
                    return new ConversorTasaEfectiva();
                case TipoTasa.Nominal:
                    return new ConversorTasaNominal();
                default:
                    return null;
            }
        }
    }
}
