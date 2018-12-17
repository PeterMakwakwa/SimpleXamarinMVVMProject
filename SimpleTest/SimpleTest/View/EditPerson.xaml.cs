using SimpleTest.Model;
using SimpleTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleTest.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPerson : ContentPage
	{
		public EditPerson (Person person)
		{
            var editvModel1 = new EditPersonViewModel();
            editvModel1.currentSelectedPerson = person;
            BindingContext = editvModel1;
           
            InitializeComponent ();
		}
	}
}