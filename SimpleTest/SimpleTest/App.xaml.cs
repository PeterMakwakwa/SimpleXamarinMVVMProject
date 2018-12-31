using CommonServiceLocator;
using SimpleTest.Services;
using System;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SimpleTest
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IDataService, DataService>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));

			MainPage = new NavigationPage( new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
