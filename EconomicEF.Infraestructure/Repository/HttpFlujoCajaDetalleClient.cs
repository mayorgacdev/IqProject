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
    public class HttpFlujoCajaDetalleClient : HttpBaseRepository<FlujoDeCajaDetalleDto>, IHttpFlujoDetalleClient
    {
        public HttpFlujoCajaDetalleClient() : base("flujoCajaDetalle")
        {

        }
        public async Task<IEnumerable<FlujoDeCajaDetalleDto>> GetByFlujoId(int flujoId)
        {
            //https://localhost:7062/api/flujoCajaDetalle/getbyflujoid?flujoId=2
            string URI = URL + "/getbyflujoid?flujoId=" + flujoId.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<FlujoDeCajaDetalleDto>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los detalles de flujo de caja asociados al flujo con id: " + flujoId.ToString());
        }

        public async Task<IEnumerable<EconomicDto>> GetEconomics(int flujo)
        {
            //https://localhost:7062/api/flujoCajaDetalle/getEconomicsbyflujo?id=1
            string URI = URL + "/getEconomicsbyflujo?id=" + flujo.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<EconomicDto>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las anualidades del flujo de caja asociados al flujo con id: " + flujo.ToString());
        }
    }
}
