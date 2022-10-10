using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes.Anualidades
{
    public class AnualidadDifCalculator : IAnualidadCalculator
    {
        public decimal CalcularPago(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double vp = (double)anualidad.ValorPresente;
            double vf = (double)anualidad.ValorFuturo;
            int numPagos = (int)anualidad.NumPeriodos - anualidad.PeriodoGracia;

            double resultado = Financial.Pmt(tasa, numPagos, vp, vf) * -1;
            if (vf == 0)
            {
                resultado *= Math.Pow((1 + tasa), anualidad.PeriodoGracia);
            }
            return Math.Round((decimal)resultado, 2);
        }

        public decimal CalcularTasa(AnnuityDto anualidad)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTiempo(AnnuityDto anualidad)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularVF(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vp = (double)anualidad.ValorPresente;
            int numPagos = (int)anualidad.NumPeriodos - anualidad.PeriodoGracia;
            vp = vp * Math.Pow((1 + tasa), anualidad.PeriodoGracia);
            double resultado = Financial.FV(tasa, numPagos, pago, vp);
            return Math.Round((decimal)resultado, 2);
        }

        public decimal CalcularVP(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vf = (double)anualidad.ValorFuturo;
            int numPagos = (int)anualidad.NumPeriodos - anualidad.PeriodoGracia;
            double resultado = Financial.PV(tasa, numPagos, pago, vf);
            if (vf == 0)
            {
                resultado *= (1 / Math.Pow((1 + tasa), anualidad.PeriodoGracia));
            }
            return Math.Round((decimal)resultado, 2);
        }
        public decimal CalcularPerGracia(AnnuityDto anualidad)
        {
            return 0;
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            throw new NotImplementedException();
        }
    }
}
