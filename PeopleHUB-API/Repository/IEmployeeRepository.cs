using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployee(int empId);
        void RegisterEmployee(Employee employee);
        Task<Employee> ValidateEmployee(string email, string password);
    }
}
