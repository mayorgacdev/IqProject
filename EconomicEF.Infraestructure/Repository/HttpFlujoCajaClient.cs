using EconomicMF.Domain.Contracts.CalculosRepositories;
using EconomicMF.Domain.Entities.Calculos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public class HttpFlujoCajaClient : HttpBaseRepository<FlujoDeCajaDto>, IHttpFlujoClient
    {
        public HttpFlujoCajaClient() : base("flujoCaja")
        {

        }
        public async Task<IEnumerable<FlujoDeCajaDto>> GetBySolutionID(int solutionID)
        {
            //https://localhost:7062/api/flujoCaja/getbysolutionid?solutionId=1
            string URI = URL + "/getbysolutionid?solutionId=" + solutionID.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<FlujoDeCajaDto>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los flujos de caja asociados a la solucion con id: " + solutionID.ToString());
        }
    }
}
