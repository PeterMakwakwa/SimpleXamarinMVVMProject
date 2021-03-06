﻿using SimpleTest.Model;
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
        private readonly IEmployee _employee_dataservice;
      
        public AddEmployeeViewModel(IEmployee dataservice)
        {
            _employee_dataservice = dataservice;
            Employee = new Employees();
        }
        public ICommand SendAddEmpployeeCommand => new Command(async () =>
        {
            try
            {
                await _employee_dataservice.PostEmployee(Employee);
            }
            catch (Exception)
            {

            }
     
        });
    }
}
