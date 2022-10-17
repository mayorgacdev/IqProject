//using EconomicEF.Common;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public abstract class HttpBaseRepository<TEntity> : IHttpClient<TEntity> where TEntity : class
    {
        protected readonly string baseUrl = "https://localhost:7062/api/";
        protected readonly string URL;
        protected static HttpClient client = new HttpClient();

        protected HttpBaseRepository(string cadena)
        {
            this.URL = baseUrl + cadena;
        }
        public async Task<int> CreateAsync(TEntity entity)
        {
            var serializedObject = JsonConvert.SerializeObject(entity);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(URL, content);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"El registro no se pudo añadir correctamente");
            }

            return 1;

        }

        public async Task<int> DeleteAsync(int guid)
        {
            string URI = URL + "?id=" + guid.ToString();
            HttpResponseMessage response = await client.DeleteAsync(URI);
            if (response.IsSuccessStatusCode)
                return guid;
            else
                return 0;
        }

        public Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> where)
        {
            //return await GetAllAsync()
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            using (var response = await client.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<TEntity>>(jsonstring);
                }
                else
                {
                    throw new Exception("Error al obtener todos los registros");
                }
            }
        }

        public async Task<TEntity> GetAsync(int guid)
        {

            string URI = URL + "/getByIdAsync?id=" + guid.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var LibroJsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TEntity>(LibroJsonString);
            }
            else
                throw new Exception($"Error al obtener el registro con id {guid}");

        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {

            // PUT: https://localhost:7062/api/project?id=1
            int id = (int)entity.GetType().GetProperty("Id").GetValue(entity);
            string URI = URL + "?id=" + id.ToString();

            var serializedObject = JsonConvert.SerializeObject(entity);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            //verificar si no tiene la propiedad de id con un try catch

            HttpResponseMessage responseMessage = await client.PatchAsync(URI, content);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception("El registro no se pudo actualizar correctamente");
            return true;

        }


    }
}
