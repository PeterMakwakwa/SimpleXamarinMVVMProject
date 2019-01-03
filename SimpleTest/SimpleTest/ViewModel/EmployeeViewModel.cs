using SimpleTest.Model;
using SimpleTest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleTest.ViewModel
{
    public class EmployeeViewModel: INotifyPropertyChanged
    {
        private List<Employees> employees { get; set;}
        private readonly IEmployee _employee_dataService;
        private bool isitrefreshing;
        public bool IsRefreshing
        {
            get { return isitrefreshing; }

            set
            {
                isitrefreshing = value;
                OnPropertyChanged();
            }
        }


        #region Update Employees List on UI whenever Whenever there's new data

        public List<Employees> EmployeeSetList
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged();
            }
        }
          

        #endregion

        public EmployeeViewModel(IEmployee dataService)
        {
            _employee_dataService = dataService;
            Getemployees();
        }

        private async Task Getemployees()
        {
            IsRefreshing = true;
            EmployeeSetList = await _employee_dataService.GetEmployees();

            IsRefreshing = false;
        }
        public ICommand RefreshCommand => new Command(async () =>
        {
            await Getemployees();
        });







        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
