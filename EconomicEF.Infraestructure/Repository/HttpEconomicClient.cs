using EconomicMF.Domain.Contracts.CalculosRepositories;
using EconomicMF.Domain.Entities.Calculos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public class HttpEconomicClient : HttpBaseRepository<EconomicDto>,IHttpEconomicClient
    {
        public HttpEconomicClient() : base("economic")
        {
        }

        public Task<int> CreateCashFlowAsync(List<EconomicDto> economicClasses, int nper)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EconomicDto>> FindByUserEmailAsync(string email)
        {
            using (var client = new HttpClient())
            {
                string URI = URL + email;
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return
                        JsonConvert.DeserializeObject<List<EconomicDto>>(jsonstring);
                }
                else
                    throw new Exception("No se pudo obtener los intereses del usuario con email: " + email);
            }
        }
    }
}
