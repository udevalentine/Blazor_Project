using EmployeeManagement.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _httpClient.GetJsonAsync<Employee>($"api/employee/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            //this is possible by installing Microsoft.AspNetCore.Blazor.HttpClient from nuget. this makes calling of RESTApi easy
            return await _httpClient.GetJsonAsync<Employee[]>("api/employee");
        }
    }
}
