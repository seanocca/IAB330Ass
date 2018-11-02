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
	public partial class InstancePage : ContentPage
	{
		public InstancePage ()
		{
			InitializeComponent ();
		}

        public void OnGuestClicked(object Sender, EventArgs args)
        {
            App.Current.MainPage = new GuestTabbedPage();
        }

        public void OnHostClicked(object Sender, EventArgs args)
        {
            App.Current.MainPage = new HostTabbedPage();
        }
    }
}