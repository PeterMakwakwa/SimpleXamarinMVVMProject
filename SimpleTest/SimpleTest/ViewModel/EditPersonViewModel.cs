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
        //private DataService dataservice = new DataService();
        private readonly IDataService _dataService;

        public EditPersonViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }
        public ICommand EditPersonCommand => new Command(async () => {
           
                await _dataService.PutPerson(currentSelectedPerson.personId, currentSelectedPerson);
        });

        public ICommand DeletePersonCommand => new Command(async () => {
           
                await _dataService.DeletePerson(currentSelectedPerson.personId);
        });

    }
}
