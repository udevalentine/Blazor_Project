using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetDepartments()
        {
            return Ok(await _departmentRepository.Departments());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetDepartment(int id)
        {
            return Ok(await _departmentRepository.GetDepartment(id));
        }
    }
}