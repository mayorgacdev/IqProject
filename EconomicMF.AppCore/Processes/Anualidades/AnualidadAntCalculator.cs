using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using Microsoft.VisualBasic;
using System;

namespace EconomicMF.AppCore.Processes.Anualidades
{
    public class AnualidadAntCalculator : IAnualidadCalculator
    {
        
        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            return 0;
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            return 0;
        }

        public decimal CalcularPago(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double vp = (double)anualidad.PresentValue;
            double vf = (double)anualidad.FutureValue;

            double resultado = Financial.Pmt(tasa, (double)anualidad.NumPeriodos, vp, vf, DueDate.BegOfPeriod) * -1;
            return Math.Round((decimal)resultado, 2);
        }

        public decimal CalcularTasa(AnnuityDto anualidad)
        {
            if (anualidad.NumPeriodos == 0)
            {
                throw new ArgumentException("El tiempo no puede ser cero");
            }
            double vp = (double)anualidad.PresentValue;
            double vf = (double)anualidad.FutureValue;
            double nper = (double)anualidad.NumPeriodos;

            double resultado = Financial.Rate(nper, -1 * (double)anualidad.PagoAnual, vp, vf, DueDate.BegOfPeriod) * 100;
            return Math.Round((decimal)resultado, 2);
        }

        public decimal CalcularTiempo(AnnuityDto anualidad)
        {
            if (anualidad.TasaInteres == 0)
            {
                throw new ArgumentException("La tasa de interes no puede ser cero");
            }
            if (anualidad.PagoAnual == 0)
            {
                throw new ArgumentException("El pago anual no puede ser cero");
            }
            double vp = (double)anualidad.PresentValue;
            double vf = (double)anualidad.FutureValue;
            double rate = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual;

            return (decimal)Math.Round(Financial.NPer(rate, -1 * pago, vp, vf, DueDate.BegOfPeriod), 2);
        }

        public decimal CalcularVF(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vp = (double)anualidad.PresentValue;

            double resultado = Financial.FV(tasa, (double)anualidad.NumPeriodos, pago, vp, DueDate.BegOfPeriod);
            return Math.Round((decimal)resultado, 2);
        }

        public decimal CalcularVP(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vf = (double)anualidad.FutureValue;

            double resultado = Financial.PV(tasa, (double)anualidad.NumPeriodos, pago, vf, DueDate.BegOfPeriod);
            return Math.Round((decimal)resultado, 2);
        }
    }
}
