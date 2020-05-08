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
                DisplayAlert("Login","Login Success","Ok");
            }
            else
            {
                DisplayAlert("Login", "Login not correcct", "Ok");
            }
        }
	}
}