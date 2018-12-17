using SimpleTest.Model;
using SimpleTest.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleTest.ViewModel
{
    public class EditPersonViewModel
    {
        public Person currentSelectedPerson { get; set; }
        private DataService dataservice = new DataService();

        public ICommand EditPersonCommand => new Command(async () => {
           
                await dataservice.PutPerson(currentSelectedPerson.personId, currentSelectedPerson);

          
        });

        public ICommand DeletePersonCommand => new Command(async () => {
           
                await dataservice.DeletePerson(currentSelectedPerson.personId);
           
        });

    }
}
