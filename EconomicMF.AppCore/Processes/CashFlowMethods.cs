using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Services.Processes
{
    public static class CashFlowMethods
    {
        public static FlujoDeCajaDto CreateCashFlow(List<EconomicDto> economicClasses, int nper, Periodo periodo)
        {
            //CODIGO ACTUAL
            decimal vp;
            var series = economicClasses.Where(e=>e.TipoDeCrecimiento.Equals(TipoCrecimiento.Geometrico) || e.TipoDeCrecimiento.Equals(TipoCrecimiento.Aritmetico));
            //vp = series.Sum(s => s.PresentValue * Math.Pow((1 + (double)s.TasaInteres), (double)-s.PeriodoGracia));
            vp = (decimal)series.Sum(s=>((double)s.PresentValue*Math.Pow((1+(double)s.TasaInteres), (double)-s.PeriodoGracia)));
            //se podria verificar con pago anual is null 
            var interesAnualidades = economicClasses.Where(e => e.Crecimiento==0 || e.Crecimiento is null);
            vp += interesAnualidades.Sum(s => s.PresentValue);
            FlujoDeCajaDto cashflow = new FlujoDeCajaDto()
            {
                SolutionId = economicClasses[0].SolutionId,
                TasaDeInteres = economicClasses[0].TasaInteres,
                PresentValue = vp,
                //Que el valor individual actue como donde se realizo el ultimmo pago
                Duracion = nper,
                FutureValue = vp * (decimal)Math.Pow((1+(double)economicClasses[0].TasaInteres), nper),
                Periodo = periodo
            };
            return cashflow;
        }
    }
}
