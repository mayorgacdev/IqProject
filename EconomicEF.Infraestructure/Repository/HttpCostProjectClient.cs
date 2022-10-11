using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public class HttpCostProjectClient : HttpBaseRepository<ProjectCost> ,IHttpCostClient
    {
        public HttpCostProjectClient() : base("cost")
        {
            
        }

        public async Task<List<ProjectCost>> GetAllCost(int projectId)
        {
            //GetCost: https://localhost:7062/api/cost/getCost?projectId=1

            string URI = URL + "/getCost?projectId=" + projectId.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<ProjectCost>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los costos del proyecto con id: " + projectId);

        }

        public async Task<bool> SetCost(ProjectCost costProjects)
        {
            //PostCost: https://localhost:7062/api/cost

            var serializedObject = JsonConvert.SerializeObject(costProjects);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(URL, content);
            if (!result.IsSuccessStatusCode)
                throw new Exception($"El registro no se pudo añadir correctamente");
            return true;
        }
    }
}
