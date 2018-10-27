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
    public partial class GuestEvent : ContentPage
    {
        public GuestEvent()
        {
            InitializeComponent();
            GuestList.IsPullToRefreshEnabled = true;
            GuestList.ItemsSource = new List<Song>
            {
                new Song
                {
                    Name = "Living on a Prayer",
                    Artist = "Jon Bon Jovi",
                    Votes = 10
                },
                new Song
                {
                    Name = "Jessies Girl",
                    Artist = "Rick Springfield",
                    Votes = 8
                },
                new Song
                {
                    Name = "Sweet Caroline",
                    Artist = "Neil Diamond",
                    Votes = 6
                },
                new Song
                {
                    Name = "Piano Man",
                    Artist = "Billy Joel",
                    Votes = 4
                },
                new Song
                {
                    Name = "Josie",
                    Artist = "The Outfield",
                    Votes = 2
                },
                new Song
                {
                    Name = "Welcome to the Jungle",
                    Artist = "Guns N' Roses",
                    Votes = 0
                },
                new Song
                {
                    Name = "Billie Jean",
                    Artist = "Micheal Jackson",
                    Votes = 0
                },
            };
        }

        public async void OnGoBack(object Sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}