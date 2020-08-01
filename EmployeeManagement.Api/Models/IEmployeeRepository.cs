using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        Task<Employee> GetEmployee(int employeeId);
        Task<IEnumerable<Employee>> AllEmployees();
    }
}
