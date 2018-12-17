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
        public Person persons { get; set; }
        private DataService dataservice = new DataService();
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

        public PeopleViewModel()
        {
            GetPeople();
        }

        private async Task GetPeople()
        {
            IsRefreshing = true;
            PeopleSetList = await dataservice.GetPeople();

            IsRefreshing = false;
        }
        public ICommand SearchPleopleCommand => new Command(async () => {

           
            await dataservice.Search(persons.personId);
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
