using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Services.Processes
{
    public static class ConvertEconomicDTOS
    {
        public static RateDto ConvertRateDto(EconomicDto economicDto)
        {
            return new RateDto()
            {
                Id = economicDto.Id,
                IdSolution = economicDto.SolutionId,
                FutureValue = economicDto.FutureValue,
                PresentValue = economicDto.PresentValue,
                TasaInteres = economicDto.TasaInteres,
                NumPeriodos = economicDto.NumPeriodos,
                TipoInteres = economicDto.TipoInteres,
                FrecuenciaTasa = economicDto.FrecuenciaTasa,
            };
        }
        public static AnnuityDto ConvertAnualidadDTO(EconomicDto economicDto)
        {
            return new AnnuityDto()
            {
                Id = economicDto.Id,
                IdSolution = economicDto.SolutionId,
                FutureValue = economicDto.FutureValue,
                PresentValue = economicDto.PresentValue,
                TasaInteres = economicDto.TasaInteres,
                NumPeriodos = economicDto.NumPeriodos,
                PagoAnual = (decimal)economicDto.PagoAnual,
                PeriodoGracia = economicDto.PeriodoGracia,
                Crecimiento = (decimal)economicDto.Crecimiento,
                FuturoGradiente = (decimal)economicDto.FuturoGradiente,
                TipoAnualidad = economicDto.TipoAnualidad,
                Periodo = economicDto.Periodo,
                TipoDeCrecimiento = economicDto.TipoDeCrecimiento
            };
        }
    }
}
