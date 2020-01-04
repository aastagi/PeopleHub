using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using AutoMapper;
using PeopleHUB_API.Resources;
using Microsoft.EntityFrameworkCore;


namespace PeopleHUB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;
        public EmployeeController(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        [HttpPost, Route("register")]
        public async Task<IActionResult> RegisterEmployee([FromBody]EmployeeResource emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var employee = mapper.Map<EmployeeResource, Employee>(emp);
            employee.CreatedDate = DateTime.Now;
            employee.ModifiedDate = DateTime.Now;
            employeeRepository.RegisterEmployee(employee);
            return Ok();


        }
        [HttpGet, Route("getAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok();
            
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await employeeRepository.GetEmployee(id);
            if (employee == null)
            {
                return BadRequest();
            }
            var result = mapper.Map<Employee, EmployeeResource>(employee);
            return Ok(result);

            
        }
    }
}