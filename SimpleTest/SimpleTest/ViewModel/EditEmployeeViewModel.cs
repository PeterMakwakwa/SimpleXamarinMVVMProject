using SimpleTest.Model;
using SimpleTest.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleTest.ViewModel
{
    public class EditEmployeeViewModel
    {
        public Employees currentSelectedEmployees { get; set; }
        private readonly IEmployee _employee_dataservice;
        public EditEmployeeViewModel(IEmployee dataService)
        {
            _employee_dataservice= dataService;
        }
       
        public ICommand EditEmployeeCommand => new Command(async () => {

            currentSelectedEmployees.employedDate = DateTime.UtcNow.ToString();
            await _employee_dataservice.PutEmployee(currentSelectedEmployees.employeeId, currentSelectedEmployees);
        });

        public ICommand DeleteEmployeeCommand => new Command(async () => {

            currentSelectedEmployees.employedDate = DateTime.UtcNow.ToString();
            await _employee_dataservice.DeleteEmployees(currentSelectedEmployees.employeeId);
        });

    }
}
