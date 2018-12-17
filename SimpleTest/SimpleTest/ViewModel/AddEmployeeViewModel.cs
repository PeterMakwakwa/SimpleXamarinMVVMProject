using SimpleTest.Model;
using SimpleTest.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleTest.ViewModel
{
    public class AddEmployeeViewModel
    {
        public Employees employee { get; set; }
        private DataService dataservice = new DataService();

        public AddEmployeeViewModel()
        {
            
            employee = new Employees();
        }
        public ICommand SendAddEmpployeeCommand => new Command(async () =>
        {
            try
            {
                employee.employedDate = DateTime.UtcNow.ToString();
                await dataservice.PostEmployee(employee);
            }
            catch (Exception)
            {

            }
     
        });
    }
}
