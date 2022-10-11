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
    public class HttpInvesmentAreaClient : HttpBaseRepository<InvesmentArea>,IHttpInvesmentAreaClient
    {
        public HttpInvesmentAreaClient() : base("invesmentArea")
        {
        }

        public async Task<List<InvesmentArea>> GetProjects(int projectId)
        {
            try
            {
                // Get: https://localhost:7062/api/invesmentArea?projectId=123

                string URI = URL + "?projectId=" + projectId.ToString();
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return
                        JsonConvert.DeserializeObject<List<InvesmentArea>>(jsonstring);
                }
                else
                    throw new Exception("No se pudo obtener las inversiones del proyecto con id: " + projectId);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> SetInvesmentArea(InvesmentArea inversionProyectos)
        {
            try
            {
                // Post: https://localhost:7062/api/invesmentArea

                using (var client = new HttpClient())
                {
                    var serializedObject = JsonConvert.SerializeObject(inversionProyectos);
                    var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(URL, content);
                    
                    if (!result.IsSuccessStatusCode)
                        throw new Exception($"El registro no se pudo añadir correctamente");
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
