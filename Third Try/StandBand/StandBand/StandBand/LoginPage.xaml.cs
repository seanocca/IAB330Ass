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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();            
        }

        public void OnLogin(object Sender, EventArgs args)
        {
            string uname = username.Text;
            string pword = password.Text;

            if (Global.UserInformation.Contains(new User() { Username = uname, Password = pword }))
            {
                App.Current.MainPage = new InstancePage();
            }
        }

        public void OnRegister(object Sender, EventArgs args)
        {
            App.Current.MainPage = new SignUpPage();
        }

        public void OnForgot(object Sender, EventArgs args)
        {
            App.Current.MainPage = new PasswordPage();
        }
    }

    public static class Global
    {
        public static List<User> UserInformation = new List<User> {
            new User() { Username = "the_band", Email = "sample@email.com", Password = "password" },
        };
    }

    public class User
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}