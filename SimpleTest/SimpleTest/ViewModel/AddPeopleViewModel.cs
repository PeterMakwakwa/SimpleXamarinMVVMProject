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
        //private Person person { get; set; }
        public Person persons { get; set; }
        private IDataService _dataservice;

        public AddPeopleViewModel(IDataService dataService)
        {
            _dataservice = dataService;
            persons = new Person();
        }

        public ICommand SendAddPersonCommand => new Command(async () =>
        {
            try
            {
                await _dataservice.PostPerson(persons);
            }
            catch (Exception)
            {

            }
     
        });
    }
}
