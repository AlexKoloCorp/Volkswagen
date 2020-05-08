using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolkswagenTest.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VolkswagenTest.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        void LogInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text,Entry_Password.Text);
            if (user.CheckInfo())
            {
                DisplayAlert("Login","Log in Success","Ok");
                App.UserDatabase.SaveUser(user);
            }
            else
            {
                DisplayAlert("Login", "Log in not correcct", "Ok");
            }
        }
        void SigInProcedure (object sender, EventArgs e)
        {
            DisplayAlert("Sigin","sig in doesn't work yet","Ok");
        }

    }
}