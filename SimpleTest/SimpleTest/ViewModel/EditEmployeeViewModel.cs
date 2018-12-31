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
        private readonly IDataService _dataservice;
        public EditEmployeeViewModel(IDataService dataService)
        {
            _dataservice= dataService;
        }
       
        public ICommand EditEmployeeCommand => new Command(async () => {

            currentSelectedEmployees.employedDate = DateTime.UtcNow.ToString();
            await _dataservice.PutEmployee(currentSelectedEmployees.employeeId, currentSelectedEmployees);
        });

        public ICommand DeleteEmployeeCommand => new Command(async () => {

            currentSelectedEmployees.employedDate = DateTime.UtcNow.ToString();
            await _dataservice.DeleteEmployees(currentSelectedEmployees.employeeId);
        });

    }
}
