using CommonServiceLocator;
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
	public partial class AddEmployee : ContentPage
	{
		public AddEmployee ()
		{
			InitializeComponent ();
            //First Solution when the axml not allowing paramiterized constructors
            //  BindingContext = ServiceLocator.Current.GetInstance<AddEmployeeViewModel>();
            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2018, 1, 1),
                MaximumDate = new DateTime(2018, 12, 31),
                Date = new DateTime(2018, 6, 21)
            };
        }
	}
}