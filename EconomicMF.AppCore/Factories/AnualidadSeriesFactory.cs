using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.AppCore.Processes.Anualidades;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Factories
{
    public static class AnualidadSeriesFactory
    {
        public  static IAnualidadCalculator CreateInstance(TipoAnualidad tipos)
        {
            switch (tipos)
            {
                case TipoAnualidad.AnualidadOrdinaria:
                    return new AnualidadOrdCalculator();
                case TipoAnualidad.AnualidadAnticipada:
                    return new AnualidadAntCalculator();
                case TipoAnualidad.AnualidadDiferida:
                    return new AnualidadDifCalculator();
                case TipoAnualidad.AnualidadPerpetua:
                    return new AnualidadPerpCalculator();
                case TipoAnualidad.SerieAritmetica:
                    return new SerieAritCalculator();
                case TipoAnualidad.SerieGeometrica:
                    return new SerieGeoCalculator();
                default:
                    return null;
            }
        }
    }
}
