using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Department>> Departments()
        {
            return await _appDbContext.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartment(int id)
        {
            return await _appDbContext.Departments.Where(f => f.DepartmentId == id).FirstOrDefaultAsync();
        }
    }
}
