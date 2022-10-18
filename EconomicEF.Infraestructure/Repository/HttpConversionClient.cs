//using EconomicEF.Common;
using EconomicMF.Domain.Contracts.CalculosRepositories;
using EconomicMF.Domain.Entities.Calculos;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public class HttpConversionClient : HttpBaseRepository<ConversionDto>,IHttpConversionClient
    {
        public HttpConversionClient() : base("conversion")
        {

        }
        public async Task<IEnumerable<ConversionDto>> GetConversionAsync(string email)
        {
            //https://localhost:7062/api/conversion/email?email=ej%40gmail.com
            string URI = URL + "/email?email=" + email;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<ConversionDto>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las conversiones del usuario con email: " + email);
        }
    }
}
