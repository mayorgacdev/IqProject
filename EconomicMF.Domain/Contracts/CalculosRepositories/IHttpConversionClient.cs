using EconomicMF.Domain.Entities.Calculos;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts.CalculosRepositories
{
    public interface IHttpConversionClient  : IHttpClient<ConversionDto>
    {
        /// <summary>
        /// Get all conversions by user email 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<IEnumerable<Conversion>> GetConversionAsync(string email);
    }
}
