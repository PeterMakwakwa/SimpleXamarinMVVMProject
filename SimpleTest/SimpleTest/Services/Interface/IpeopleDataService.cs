using SimpleTest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest.Services
{
    public interface IPeopleDataService
    {
        Task DeletePerson(int id);
        Task<List<Person>> GetPeople();
        Task PostPerson(Person person);
        Task PutPerson(int id, Person person);
        Task<Person> Search(int ID);
    }
}
