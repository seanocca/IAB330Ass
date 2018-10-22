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
            var uname = username.Text;
            var emailAddress = "";
            var pass = "";

            if (email.Text == c_email.Text)
            {
                emailAddress = email.Text;
            }
            else
            {
                email_error.Text = "Email Address' Do Not Match!";
            }

            if (password.Text == c_password.Text & password.Text != "")
            {
                pass = password.Text;
            }
            else
            {
                password_error.Text = "Password's Do Not Match!";
            }

            if (!Global.UserInformation.Contains(new User() { Username = uname, Email = emailAddress }) & emailAddress != "" & pass != "" & uname != "")
            {
                User user = new User() { Username = uname, Email = emailAddress, Password = pass };
                Global.UserInformation.Add(user);
                App.Current.MainPage = new LoginPage();
            }
        }
	}
}