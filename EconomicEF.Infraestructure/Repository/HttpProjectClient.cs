using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public class HttpProjectClient :HttpBaseRepository<ProjectClient>, IHttpProjectClient
    {
        public HttpProjectClient() : base("project")
        {
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
        public async Task<IEnumerable<ProjectClient>> GetProjectsAsync(int solution)
        {
            //Get: https://localhost:7062/api/project/getprojectsbysolutionid?solutionId=12

            string URI = URL + "/getprojectsbysolutionid?solutionId=" + solution.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<ProjectClient>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los proyectos asociados con la solucion de id: " + solution.ToString());

        }

        public async Task<bool> SetProjectToSolution(ProjectClient project)
        {
            using (var client = new HttpClient())
            {
                var serializedObject = JsonConvert.SerializeObject(project);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);

                if (!result.IsSuccessStatusCode)
                    throw new Exception($"El registro no se pudo añadir correctamente");
                return true;
            }
        }
    }
}
