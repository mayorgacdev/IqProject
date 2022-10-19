using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Services.Processes.Intereses;
using System.Collections.Generic;

namespace EconomicMF.Helper
{
    public class RepositoryOthers
    {
        public List<AssetOther> assets { get; set; } = new List<AssetOther>();
        public List<Prestamo> prestamos { get; set; } = new List<Prestamo>();
    }
}
