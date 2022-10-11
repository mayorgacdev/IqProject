using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.DTO;
using EconomicMF.Domain.Entities.DataWithList;
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
    public class HttpInvesmentEntityClient : HttpBaseRepository<InvesmentEntity>, IHttpIInvesmentEntityClient
    {
        public HttpInvesmentEntityClient() : base("invesmentEntity")
        {
        }
        // TODO: look at project
        public async Task<List<InvesmentEntity>> GetByProjectIdAsync(int projectId)
        {
            // Get: https://localhost:7062/api/invesmentEntity/GetByProjectIdAsync?projectId=1

            string URI = URL + "/GetByProjectIdAsync?projectId=" + projectId.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<InvesmentEntity>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las inversiones del proyecto con id: " + projectId);
        }

        public async Task<IEnumerable<InvesmentEntity>> GetBySolutionIdAsync(int idSolution)
        {
            // Get: https://localhost:7062/api/invesmentEntity?solutionId=1



            string URI = URL + "?solutionId=" + idSolution.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<InvesmentEntity>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las inversiones de la solucion con id: " + idSolution);
        }

        public async Task<InvesmentEntity> GetOneInvesmentAsync(int projectId)
        {
            string URI = URL + "?solutionId=" + projectId.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<InvesmentEntity>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las inversiones de la solucion con id: " + projectId);
        }

        public async Task<IEnumerable<HasTrabajadoCon>> GetUniqueNames(int solutionId)
        {
            string URI = URL + "/getUniques?solutionId=" + solutionId.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);

            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<IEnumerable<HasTrabajadoCon>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las inversiones de la solución con id: " + solutionId);

        }

        public async Task<bool> SetInvesmentEntityAsync(InvesmentEntity entidadInvs)
        {
            try
            {
                // Post: https://localhost:7062/api/invesmentEntity


                var serializedObject = JsonConvert.SerializeObject(entidadInvs);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);

                if (!result.IsSuccessStatusCode)
                    throw new Exception($"El registro no se pudo añadir correctamente");
                return true;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
