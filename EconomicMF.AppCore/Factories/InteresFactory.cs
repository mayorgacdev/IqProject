using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.AppCore.Processes.Intereses;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Factories
{
    public static class InteresFactory
    {
        public static IRateCalculator CreateInstance(TipoInteres tipoInteres)
        {
            switch (tipoInteres)
            {
                case TipoInteres.Simple:
                    return new InteresSimpleCalculator();
                case TipoInteres.CompuestoConTasaNominal:
                    return new InteresNominalCalculator();
                case TipoInteres.CompuestoConTasaEfectiva:
                    return new InteresEfectivoCalculator();
                default:
                    return null;
            }
        }
    }
}
