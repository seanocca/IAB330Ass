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
	public partial class PasswordPage : ContentPage
	{
		public PasswordPage ()
		{
			InitializeComponent ();
		}

        public void OnForgotPassword(object Sender, EventArgs args)
        {
            var username = forgotUsername.Text;
            if (username == "the_band") 
            {
                App.Current.MainPage = new LoginPage();
            }
        }
	}
}