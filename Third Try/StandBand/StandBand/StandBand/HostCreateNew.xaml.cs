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
		public HostCreateNew ()
		{
			InitializeComponent ();
		}

        async void OnCreateNew(object Sender, EventArgs args)
        {
            await Navigation.PushAsync(new HostEvent());
        }
	}
}