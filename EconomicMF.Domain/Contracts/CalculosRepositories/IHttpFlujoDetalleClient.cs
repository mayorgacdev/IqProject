using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts.CalculosRepositories
{
    public interface IHttpFlujoDetalleClient : IHttpClient<FlujoDeCajaDetalleDto>
    {
        Task<IEnumerable<FlujoDeCajaDetalleDto>> GetByFlujoId(int flujoId);
        Task<IEnumerable<EconomicDto>> GetEconomics(int flujoDetalle);
    }
}
