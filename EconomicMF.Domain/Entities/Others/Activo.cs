using EconomicMF.Domain.Entities.Flows;
using System;

namespace EconomicMF.Domain.Entities.Others
{
    public class Activo
    {
        public int Id { get; set; }
        public int SolutionId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Tiempo { get; set; }
        public decimal ValorResidual{ get; set; }
        public string Descripcion { get; set; }
        public DateTime Creación { get; set; }
        public Solution Solution { get; set; }
    }
}
