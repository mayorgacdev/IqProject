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
    public class HttpAssetClient : HttpBaseRepository<Asset>, IHttpAssetClient
    {
        public HttpAssetClient() : base("asset")
        {
        }

        public async Task<List<Asset>> GetAllAssetAsync(int projectId)
        {
            string URI = URL + "/getAssets?projectId=" + projectId.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<Asset>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los costos del proyecto con id: " + projectId);
        }

        public async Task<bool> SetAssetAsync(Asset asset)
        {
            var serializedObject = JsonConvert.SerializeObject(asset);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(URL, content);
            if (!result.IsSuccessStatusCode)
                throw new Exception($"El registro no se pudo añadir correctamente");
            return true;
        }
    }
}
