using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Flows
{
    public class InversionTotalDeProyecto
    {
        public int Id { get; set; }
        public List<InvesmentEntity> entidadInvs { get; set; }
        public List<InvesmentArea> areaInversions { get; set; }
        public decimal Tasa { get => GetTMAR(); set => GetTMAR(); }
        public decimal Total => areaInversions.Sum(e => e.Amount);
        public decimal GetTMAR()
        {
            var prestamo = entidadInvs.Where(e => e.MoneyLoan == true);
            var aportacionTotal = prestamo.Sum(e => e.Contribution);
            var aportacionInversor = entidadInvs.Where(e => e.MoneyLoan == false);
            var aportacionInversorTotal = aportacionInversor.Sum(e => e.Contribution);
            List<decimal> aportacionPrestamo = new List<decimal>();
            List<decimal> aportacion = new List<decimal>();

            if (aportacionTotal > 100 || aportacionTotal < 0)
            {
                throw new Exception("La aportación debe ser igual al 100%");
            }

            foreach (var item in prestamo)
            {
                aportacionPrestamo.Add((decimal)(item.Contribution * item.Rate));
            }

            if (aportacionInversorTotal > 100 || aportacionInversorTotal < 0)
            {
                throw new Exception("La aportación debe ser igual al 100%");
            }

            foreach (var item in aportacionInversor)
            {
                aportacion.Add((decimal)(item.Contribution * item.Rate));
            }

            var total = aportacionInversorTotal + aportacionTotal;
            var data = Enumerable.Concat(aportacionPrestamo, aportacion);

            if (total == 100)
            {
                foreach (var item in data)
                {
                    Tasa += item;
                }
                return Tasa;
            }
            else
            {
                throw new Exception("La aportación debe ser igual al 100%");
            }

        }

        public InversionTotalDeProyecto(List<InvesmentEntity> entidadInvs, List<InvesmentArea> areaInversions)
        {
            this.entidadInvs = entidadInvs;
            this.areaInversions = areaInversions;
        }
    }
}
