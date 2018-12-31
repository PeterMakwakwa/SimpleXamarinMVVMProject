using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleTest.Model;

namespace SimpleTest.Services
{
    public interface IDataService
    {
        Task DeleteEmployees(int id);
        Task DeletePerson(int id);
        Task<List<Employees>> GetEmployees();
        Task<List<Person>> GetPeople();
        Task PostEmployee(Employees employ);
        Task PostPerson(Person person);
        Task PutEmployee(int id, Employees employ);
        Task PutPerson(int id, Person person);
        Task<Person> Search(int ID);
    }
}