using BstuGO.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BstuGO.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		DBServices services = new DBServices();
		
		public LoginPage ()
		{
			InitializeComponent ();
			bool HasKey = Preferences.ContainsKey("token");
			if (HasKey)
			{
				string token = Preferences.Get("token","");
				if (!string.IsNullOrEmpty(token))
				{
					Navigation.PushModalAsync(new MainPage());
				}
				
			}

		}

        private async void BtnSignIN_Clicked(object sender, EventArgs e)
        {
			string email = TxtEmail.Text;
			string password = TxtPaswword.Text;
			string token = await services.SignIn(email, password);
			if (!string.IsNullOrEmpty(token))
			{
				Preferences.Set("token", token);
				Preferences.Set("email",email);

				await Navigation.PushModalAsync(new MainPage());
			}
			else
			{
				await DisplayAlert("Sign in", "Failed","OK");
			}
        }
    }
}