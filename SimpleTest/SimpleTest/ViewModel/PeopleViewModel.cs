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
    public class PeopleViewModel : INotifyPropertyChanged
    {
        private List<Person> peoples { get; set;}
        private Person persn { get; set; }
       
        private readonly IDataService _dataService;
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

        public List<Person> PeopleSetList
        {
            get { return peoples; }
            set
            {
                peoples = value;
                OnPropertyChanged();
            }
        }
          

        #endregion

        public PeopleViewModel(IDataService dataService)
        {
            _dataService = dataService;
            persn = new Person();
            GetPeople();
        }

        private async Task GetPeople()
        {
            IsRefreshing = true;
            PeopleSetList = await _dataService.GetPeople();

            IsRefreshing = false;
        }
        public ICommand SearchPleopleCommand => new Command(async () => {

           
            await _dataService.Search(persn.personId);
        });

       

        public ICommand RefreshCommand => new Command(async () =>
        {
            try
            {
                await GetPeople();

            }
            catch (Exception)
            {
            }

        });







        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
