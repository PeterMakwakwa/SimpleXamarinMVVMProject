using SimpleTest.Model;
using SimpleTest.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleTest.ViewModel
{
    public class AddPeopleViewModel
    {
        
        public Person persons { get; set; }
       
        private IPeopleDataService _people_dataservice;

        public AddPeopleViewModel(IPeopleDataService dataService)
        {
            _people_dataservice = dataService;
            persons = new Person();
        }

        public ICommand SendAddPersonCommand => new Command(async () =>
        {
            try
            {
                await _people_dataservice.PostPerson(persons);
            }
            catch (Exception)
            {

            }
     
        });
    }
}
