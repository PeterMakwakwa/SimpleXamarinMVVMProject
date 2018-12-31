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
        public Employees Employee { get; set; }
        private readonly IDataService _dataservice;
      
        public AddEmployeeViewModel(IDataService dataservice)
        {
            _dataservice = dataservice;
            Employee = new Employees();
        }
        public ICommand SendAddEmpployeeCommand => new Command(async () =>
        {
            try
            {
                Employee.employedDate = DateTime.UtcNow.ToString();
              
                await _dataservice.PostEmployee(Employee);
            }
            catch (Exception)
            {

            }
     
        });
    }
}
