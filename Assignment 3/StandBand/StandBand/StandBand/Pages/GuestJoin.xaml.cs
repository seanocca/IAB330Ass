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

            EventList.ItemsSource = new List<Event>
            {
                new Event
                {
                    Band_Name = "Dancing Monkeys",
                    Location = "Kingsley Pub",
                    Time = "9:00pm"
                },
                new Event
                {
                    Band_Name = "Big People",
                    Location = "Comedy Centre Brisbane",
                    Time = "5:00pm"
                },
                new Event
                {
                    Band_Name = "Scrantonicity",
                    Location = "Centre for Songs",
                    Time = "1:00pm"
                },
                new Event
                {
                    Band_Name = "World Eaters",
                    Location = "Scott Paper Company",
                    Time = "6:00pm"
                },
                new Event
                {
                    Band_Name = "Big Tape",
                    Location = "Kingsley Pub",
                    Time = "7:00pm"
                },
                new Event
                {
                    Band_Name = "Freezing Four",
                    Location = "People Company",
                    Time = "1:00am"
                },
                new Event
                {
                    Band_Name = "Bottled Water",
                    Location = "Big Tuna Pub",
                    Time = "3:00pm",
                },
                new Event
                {
                    Band_Name = "Keyboard Warriors",
                    Location = "Halpert Food Co.",
                    Time = "5:30pm"
                },
                new Event
                {
                    Band_Name = "Speaker City",
                    Location = "Loud People United",
                    Time = "6:30pm"
                },
                new Event
                {
                    Band_Name = "Stick it To Them",
                    Location = "Songs for the Deaf",
                    Time = "8:00pm"
                },
            };
        }

        public async void OnJoin(object Sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new GuestEvent());
        }
    }
}