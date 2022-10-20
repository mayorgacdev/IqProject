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
    public class AnualidadOrdCalculator : IAnualidadCalculator
    {
        public decimal CalcularPago(AnnuityDto anualidad)
        {
            if (anualidad.NumPeriodos == 0)
            {
                throw new ArgumentException("El numero de periodos no puede ser cero");
            }
            double tasa = (double)anualidad.TasaInteres;
            double vp = (double)anualidad.PresentValue;
            double vf = (double)anualidad.FutureValue;

            double resultado = Financial.Pmt(tasa, (double)anualidad.NumPeriodos, vp, vf) * -1;
            return Math.Round((decimal)resultado, 4);
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

            double resultado = Financial.Rate(nper, -1 * (double)anualidad.PagoAnual, vp, vf) * 100;
            return Math.Round((decimal)resultado, 4);
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

            return (decimal)Math.Round(Financial.NPer(rate, -1 * pago, vp, vf), 4);
        }

        public decimal CalcularVF(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vp = (double)anualidad.PresentValue;

            double resultado = Financial.FV(tasa, (double)anualidad.NumPeriodos, pago, vp);
            return Math.Round((decimal)resultado, 4);
        }

        public decimal CalcularVP(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vf = (double)anualidad.FutureValue;

            double resultado = Financial.PV(tasa, (double)anualidad.NumPeriodos, pago, vf);
            return Math.Round((decimal)resultado, 4);
        }
        #region no
        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            return 0;
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            return 0;
        }
        #endregion
    }
}
