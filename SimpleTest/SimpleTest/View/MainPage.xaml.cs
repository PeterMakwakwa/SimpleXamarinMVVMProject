using SimpleTest.Model;
using SimpleTest.Services;
using SimpleTest.View;
using SimpleTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new EmployeeViewModel(new EmployeeDataService());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployee());
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var employe = e.Item as Employees;

            Navigation.PushAsync(new EditEmployees(employe));
        }


        private async void Button_Clicked_ViewPeople(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PeopleMainPage());
        }
    }
}
