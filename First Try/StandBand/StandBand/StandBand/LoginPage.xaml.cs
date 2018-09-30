using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StandBand
{
	public partial class LoginPage : ContentPage
    {
        public MobileServiceClient mobileService = new MobileServiceClient("https://standband.azurewebsites.net");

        // Set everything up on the page
        public LoginPage()
		{
            InitializeComponent();
		}
        
        // Check the sign in on the database
        async void LoginClicked(object sender, EventArgs args)
        {
            CurrentPlatform.Init();
            User user = new User { username = "what", password = "yes"};
            await mobileService.GetTable<User>().InsertAsync(user);
            await Navigation.PushAsync(new InstancePage());
        }

        // Redirect the page to the Register Page
        async void RegisterClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
