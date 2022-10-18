using EconomicMF.Domain.Entities.Calculos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts.CalculosRepositories
{
    public interface IHttpEconomicClient : IHttpClient<EconomicDto>
    {
        /// <summary>
        /// Find user by one email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        //Task<IEnumerable<EconomicDto>> FindByUserEmailAsync(string email);

        /// <summary>
        /// Create a flows by many economic classes
        /// </summary>
        /// <param name="economicClasses"></param>
        /// <param name="nper"></param>
        /// <returns></returns>
        //Task<int> CreateCashFlowAsync(List<EconomicDto> economicClasses, int nper);
        Task<IEnumerable<RateDto>> GetInteresAsync(int userId);
        Task<IEnumerable<AnnuityDto>> GetAnualidadesAsync(int userId);
        Task<IEnumerable<EconomicDto>> GetPureEconomicAsync(int userId);
    }
}
