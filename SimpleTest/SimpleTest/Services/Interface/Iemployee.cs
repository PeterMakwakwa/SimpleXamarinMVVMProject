using SimpleTest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest.Services
{
    public interface IEmployee
    {
        Task DeleteEmployees(int id);
        Task<List<Employees>> GetEmployees();
        Task PostEmployee(Employees employ);
        Task PutEmployee(int id, Employees employ);
    }
}
