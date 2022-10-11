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
    public class HttpProjectEntryClient : HttpBaseRepository<ProjectEntry>,IHttpProjectEntryClient
    {
        public HttpProjectEntryClient() : base("entry")
        {
        }

        public async Task<List<ProjectEntry>> GetEntriesAsync(int projectId)
        {
            // Get: https://localhost:7062/api/entry?projectId=12

            string URI = URL + "?projectId=" + projectId.ToString();

            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<ProjectEntry>>(jsonstring);
                }
                else
                {
                    throw new Exception("Error al obtener todos los registros");
                }
            }

        }

        public async Task<bool> SetEntriesAsync(ProjectEntry ingresoProyectos)
        {
            // Post: https://localhost:7062/api/entry

            using (var client = new HttpClient())
            {
                var serializedObject = JsonConvert.SerializeObject(ingresoProyectos);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);

                if (!result.IsSuccessStatusCode)
                    throw new Exception($"El registro no se pudo añadir correctamente");
                return true;
            }
        }
    }
}
