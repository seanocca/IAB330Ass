﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StandBand
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GuestTabbedPage : TabbedPage
	{
        public GuestTabbedPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}