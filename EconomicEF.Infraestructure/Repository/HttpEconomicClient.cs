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

        //public Task<int> CreateCashFlowAsync(List<EconomicDto> economicClasses, int nper)
        //{
        //    throw new NotImplementedException();
        //}

        //TODO: Este metodo nunca se usa 
        //public async Task<IEnumerable<EconomicDto>> FindByUserEmailAsync(string email)
        //{
        //    //https://localhost:7062/api/economic/findByUseremail?email=ej%40gmail.com
        //    string URI = URL + "/findByUseremail?email=" + email;
        //    HttpResponseMessage response = await client.GetAsync(URI);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var jsonstring = await response.Content.ReadAsStringAsync();
        //        return
        //            JsonConvert.DeserializeObject<List<EconomicDto>>(jsonstring);
        //    }
        //    else
        //        throw new Exception("No se pudo obtener los intereses o anualidades del usuario con email: " + email);
        //}

        public async Task<IEnumerable<AnnuityDto>> GetAnualidadesAsync(int solutionId)
        {
            //https://localhost:7062/api/economic/anualidad/1
            string URI = URL + "/anualidad/" + solutionId;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<AnnuityDto>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las anualidades de la solucion con id: " + solutionId);
        }

        public async Task<IEnumerable<RateDto>> GetInteresAsync(int solutionId)
        {
            //https://localhost:7062/api/economic/interes/1
            string URI = URL + "/interes/" + solutionId;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<RateDto>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los intereses de la solucion con id: " + solutionId);
        }

        public async Task<IEnumerable<EconomicDto>> GetPureEconomicAsync(int solutionId)
        {
            //https://localhost:7062/api/economic/1
            string URI = URL + "/" + solutionId;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<EconomicDto>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los intereses o anualidades de la solucion con id: " + solutionId);
        }
    }
}
