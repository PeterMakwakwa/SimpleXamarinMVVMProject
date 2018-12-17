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
        private Person person { get; set; }
        private DataService dataservice = new DataService();

        public AddPeopleViewModel()
        {
            person = new Person();
        }
        public ICommand SendAddPersonCommand => new Command(async () =>
        {
            try
            {
                await dataservice.PostPerson(person);
            }
            catch (Exception)
            {

            }
     
        });
    }
}
