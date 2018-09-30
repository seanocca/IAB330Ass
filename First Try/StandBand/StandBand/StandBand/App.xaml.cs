using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace StandBand
{ 
    public partial class App : Application
    { 
        private ContentPage loginPage;
		public App ()
		{
			InitializeComponent();

			loginPage = new LoginPage();
            MainPage = new NavigationPage(loginPage);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
