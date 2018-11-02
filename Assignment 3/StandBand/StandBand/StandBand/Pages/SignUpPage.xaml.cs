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
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
		}

        public void OnRegister(object Sender, EventArgs args)
        {
            string uname = username.Text;
            string emailAddress = "";
            string pass = "";

            if (email.Text == c_email.Text & email.Text != "")
            {
                emailAddress = email.Text;
            }
            else
            {
                register_error.Text = "Email Address' Do Not Match!";
            }

            if (password.Text == c_password.Text & password.Text != "")
            {
                pass = password.Text;
            }
            else
            {
                register_error.Text = "Password's Do Not Match!";
            }

            if (email.Text == "" || password.Text == "" || uname == "")
            {
                register_error.Text = "Please Fill in All Fields!";
            } 
            else
            {
                App.Current.MainPage = new LoginPage();
            }
        }
	}
}