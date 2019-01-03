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
        private readonly IPeopleDataService _people_dataService;

        public EditPersonViewModel(IPeopleDataService dataService)
        {
            _people_dataService = dataService;
        }
        public ICommand EditPersonCommand => new Command(async () => {
           
                await _people_dataService.PutPerson(currentSelectedPerson.personId, currentSelectedPerson);
        });

        public ICommand DeletePersonCommand => new Command(async () => {
           
                await _people_dataService.DeletePerson(currentSelectedPerson.personId);
        });

    }
}
