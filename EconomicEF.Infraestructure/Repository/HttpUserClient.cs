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

    public class HttpUserClient : HttpBaseRepository<User>,IHttpUserClient
    {
        public HttpUserClient() : base("user")
        {
        }

        public async Task<bool> AccessToAppAsync(string email, string password)
        {
            //https://localhost:7062/api/user/others/access?email=ej%40gmail.com&name=oscar&password=ej%40gmail.com

            string URI = URL + $"/others/access?email={email}&password={password}";
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<bool>(jsonstring);
            }
            else
                throw new Exception("No se pudo acceder a esta cuenta");

        }

        public async Task<bool> ExistEmailAsync(string email)
        {
            //https://localhost:7062/api/user/others/existemail?email=ej%40gmail.com

            string URI = URL + "/others/existemail?email=" + email;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                //TODO: verificar si es un true o false
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<bool>(jsonstring);
            }
            else
                throw new Exception("Hubo un error al comprobar la existencia de ese email");

        }

        public async Task<User> GetByEmailAsync(string email)
        {
            //https://localhost:7062/api/user/getbyemail?name=ej%40gmail.com'

            string URI = URL + "/getbyemail?name=" + email;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<User>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener el usuario con email: " + email);

        }

        public async Task<User> GetByNameAsync(string name)
        {
            //https://localhost:7062/api/user/getbyname?name=oscar

            string URI = URL + "/getbyname?name=" + name;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<User>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener el usuario con el nombre: " + name);

        }
        //TODO: Aqui se retorna un solutionDto
        public async Task<IEnumerable<Solution>> GetByUserAsync(int usuario)
        {
            //https://localhost:7062/api/user/getsolutions/userid?userId=1

            string URI = URL + "/getsolutions/userid?userId=" + usuario.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<Solution>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener las soluciones asociadas al usuario con id: " + usuario.ToString());

        }
        //TODO: No esta implementado en la API
        public async Task<RecoveryPassword> RecoveryPasswordAsync(string email)
        {
            //https://localhost:7062/api/user/others/recoverpassword?email=ej%40gmail.com

            string URI = URL + "/others/recoverpassword?email=" + email;
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<RecoveryPassword>(jsonstring);
            }
            else
                throw new Exception("ERROR al recuperar la contraseña");

        }
    }
}