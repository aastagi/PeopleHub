using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleHUB_API.Services;

namespace PeopleHUB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeService employeeService = new EmployeeService();
        //public EmployeeController(EmployeeService employeeService)
        //{
        //    this.employeeService = employeeService; 
        //}

        [HttpPost, Route("addEmployee")]
        public ActionResult AddEmployee(Employee emp)
        {
            try
            {
                this.employeeService.saveEmployeeRecord(emp);
                return Content("Saved!");
            }
            catch (Exception e)
            {
                return Content("Something went wrong!");
            }
        }
        [HttpGet, Route("getAllEmployees")]
        public ActionResult GetAllEmployees()
        {
            try
            {
                return Content("All");
            }
            catch (Exception e) {
                return Content("No Employees");
            }
            
        }
    }
}