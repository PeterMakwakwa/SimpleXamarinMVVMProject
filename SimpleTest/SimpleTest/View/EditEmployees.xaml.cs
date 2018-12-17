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
	public partial class EditEmployees : ContentPage
	{
		public EditEmployees (Employees emplo)
		{
            var editvModel = new EditEmployeeViewModel();
            editvModel.currentSelectedEmployees = emplo;
            BindingContext = editvModel;
            InitializeComponent();

        }
	}
}