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
	public partial class PeopleMainPage : ContentPage
	{
		public PeopleMainPage()
		{
			InitializeComponent();
            BindingContext = new PeopleViewModel(new DataService());

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPeople());
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var persons = e.Item as Person;

            Navigation.PushAsync(new EditPerson(persons));
        }

        private void SearchBar_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var container = BindingContext as PeopleViewModel;
            PeopleList.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                PeopleList.ItemsSource = container.PeopleSetList;
            else
                PeopleList.ItemsSource = container.PeopleSetList.Where(p => p.firstName.Contains(e.NewTextValue));
            PeopleList.BeginRefresh();

        }

        private void poeplesearch_SearchButtonPressed(object sender, EventArgs e)
        {
            var container = BindingContext as PeopleViewModel;
            PeopleList.BeginRefresh();

            string keyword = poeplesearch.Text;
            PeopleList.ItemsSource = container.PeopleSetList.Where(p => p.firstName.Contains(keyword));
            PeopleList.BeginRefresh();
        }
    }
}
