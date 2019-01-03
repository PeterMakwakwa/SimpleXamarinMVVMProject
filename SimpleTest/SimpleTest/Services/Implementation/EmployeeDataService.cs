using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleTest.Model;

namespace SimpleTest.Services
{
    public class EmployeeDataService : IEmployee
    {
        private readonly string URlEmployee = "https://techtestapi.azurewebsites.net/api/Employees";
        public async Task<List<Employees>> GetEmployees()
        {
            List<Employees> tempEmployeeList = new List<Employees>();
            try
            {
                var httpclient = new HttpClient();
                var json = await httpclient.GetStringAsync(URlEmployee);
                var employeeList = JsonConvert.DeserializeObject<List<Employees>>(json);
                return employeeList;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task PostEmployee(Employees employ)
        {
            try
            {
                var httpclient = new HttpClient();
                var json = JsonConvert.SerializeObject(employ);
                StringContent content = new StringContent(json);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var results = await httpclient.PostAsync(URlEmployee, content);

            }
            catch (Exception)
            {
            }

        }

        public async Task PutEmployee(int id, Employees employ)
        {
            try
            {
                var httpclient = new HttpClient();
                var json = JsonConvert.SerializeObject(employ);
                StringContent content = new StringContent(json);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var results = await httpclient.PutAsync(URlEmployee + "/" + id, content);

            }
            catch (Exception)
            {
            }

        }



        public async Task DeleteEmployees(int id)
        {

            try
            {
                var httpclient = new HttpClient();
                var response = await httpclient.DeleteAsync(URlEmployee + "/" + id);
            }
            catch (Exception)
            {

            }


        }
    }
}
