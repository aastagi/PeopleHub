using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;
namespace PeopleHUB_API.Services
{
    public class EmployeeService
    {
        private DataContext context;
        public void saveEmployeeRecord(Employee emp)
        {
            this.context.Employees.Add(emp);
            emp.CreatedDate = DateTime.Now;
            emp.ModifiedDate = DateTime.Now;
            this.context.SaveChanges();
        }
    }
}
