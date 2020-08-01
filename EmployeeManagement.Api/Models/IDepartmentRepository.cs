﻿using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository
    {
        Task<Department> GetDepartment(int id);
        Task<IEnumerable<Department>> Departments();
    }
}
