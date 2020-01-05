using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly  DataContext context;
        public EmployeeRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }
        public async Task<Employee> GetEmployee(int employeeId)
        {
            Employee employee = await context.Employees.SingleOrDefaultAsync(e => e.EmployeeId == employeeId);
            return employee;

        }
        public void RegisterEmployee(Employee employee)
        {
            this.context.Add(employee);
            this.context.SaveChanges();
        }
    }
}
