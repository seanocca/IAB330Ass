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
	public partial class HostEvent : ContentPage
	{
		public HostEvent ()
		{
			InitializeComponent ();
            Title = HostCreateNew.event_name;
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}