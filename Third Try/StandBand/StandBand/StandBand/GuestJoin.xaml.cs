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
	public partial class GuestJoin : ContentPage
	{
		public GuestJoin ()
		{
			InitializeComponent ();
        }

        public async void OnJoin(object Sender, EventArgs args)
        {
            await Navigation.PushAsync(new GuestEvent());
        }
    }
}