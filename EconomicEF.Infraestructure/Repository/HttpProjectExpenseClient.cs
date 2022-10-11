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
    public class HttpProjectExpenseClient : HttpBaseRepository<ProjectExpense>,IHttpProjectExpenseClient
    {
        public HttpProjectExpenseClient() : base("expense")
        {
        }
        public async Task<List<ProjectExpense>> GetAllExpenses(int projectId)
        {
            //Get: https://localhost:7062/api/expense/getexpensesbyprojectid?projectId=123

            string URI = URL + "/getexpensesbyprojectid?projectId=" + projectId.ToString();
            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return
                    JsonConvert.DeserializeObject<List<ProjectExpense>>(jsonstring);
            }
            else
                throw new Exception("No se pudo obtener los gastos asociadas al proyecto con id: " + projectId.ToString());


        }

        public async Task<bool> SetExpense(ProjectExpense gastoProjects)
        {
            // Post: https://localhost:7062/api/expense/setExpenseAsync

            using (var client = new HttpClient())
            {
                var serializedObject = JsonConvert.SerializeObject(gastoProjects);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);

                if (!result.IsSuccessStatusCode)
                    throw new Exception($"El registro no se pudo añadir correctamente");
                return true;
            }
        }
    }
}
