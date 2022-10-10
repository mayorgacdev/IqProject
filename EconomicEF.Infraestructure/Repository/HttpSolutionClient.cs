//using EconomicEF.Common;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public class HttpSolutionClient : HttpBaseRepository<Solution>, IHttpSolutionClient
    {

        public HttpSolutionClient() : base("solution")
        {
        }

        public async Task<IEnumerable<Solution>> GetByUserAsync(int userId)
        {
            // Get: https://localhost:7062/api/solution/getsolutionsbyuserid?userId=123

            string URI = URL + "/getsolutionsbyuserid?userId=" + userId.ToString();
            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Solution>>(jsonstring);
                }
                else
                {
                    throw new Exception("Error al obtener todos los registros");
                }
            }
        }

        public async Task<IEnumerable<Solution>> GetByUserEmailAsync(string email)
        {
            // Get: https://localhost:7062/api/solution/getsolutionsbyemail?email=mayorga077708%40gmail.com

            string URI = URL + "/getsolutionsbyemail?email=" + email;
            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Solution>>(jsonstring);
                }
                else
                {
                    throw new Exception("Error al obtener todos los registros");
                }
            }

        }

        public async Task<Solution> GetSolutionByIdAsync(int userId)
        {
            // Get:https://localhost:7062/api/solution/getByIdAsync?id=2

            string URI = URL + "/getsolutionsbyuserid?userId=" + userId.ToString();
            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Solution>(jsonstring);
                }
                else
                {
                    throw new Exception("Error al obtener todos los registros");
                }
            }

        }

        public async Task<int> LastCreatedAsync()
        {
            // GET: https://localhost:7062/api/solution/getLast
            string URI = URL + "/getLast";

            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<int>(jsonstring);
                }
                else
                {
                    throw new Exception("Error al obtener todos los registros");
                }
            }

        }

        public async Task<bool> SetSolutionToUserAsync(Solution solution)
        {
            //Post:https://localhost:7062/api/solution/setSolutionAsync


            string URI = URL;
            var serializedObject = JsonConvert.SerializeObject(solution);

            //var res = await client.PostAsJsonAsync(URI, serializedObject);

            var content = new StringContent(serializedObject, Encoding.Default, "application/json");
            var result = await client.PostAsync(URI, content);

            if (!result.IsSuccessStatusCode)
                throw new Exception($"El registro no se pudo añadir correctamente");

            return true;


        }
    }
}
