using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StandBand
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HostCreateNew : ContentPage
	{
        public static string event_name;

		public HostCreateNew ()
		{
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(new HostEvent(), true);
        }

        async void OnCreateNew(object Sender, EventArgs args)
        {
            event_name = name.Text;
            string list = setList.ToString();
            string local = location.Text;
            if (event_name != null & list != null & local != null)
            {
                await Navigation.PushAsync(new HostEvent());
            }
            else
            {
                errorLabel.Text = "Please enter information in all fields marked with a *";
            }
        }
	}
}