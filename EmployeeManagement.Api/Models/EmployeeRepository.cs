using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result=await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<Employee>> AllEmployees()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async void DeleteEmployee(int employeeId)
        {
            var employee=await GetEmployee(employeeId);
            if(employee!=null)
            {
                _appDbContext.Remove(employee);
               await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await _appDbContext.Employees.Where(f => f.EmployeeId == employeeId)
                .Include(f=>f.Department)
                .FirstOrDefaultAsync();
        }
    }
}
