using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts.CalculosRepositories
{
    public interface IHttpFlujoClient : IHttpClient<FlujoDeCajaDto>
    {
        Task<IEnumerable<FlujoDeCajaDto>> GetBySolutionID(int solutionID);
    }
}
