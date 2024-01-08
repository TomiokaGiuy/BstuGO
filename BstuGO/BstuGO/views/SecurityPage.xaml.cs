using BstuGO.services;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BstuGO.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecurityPage : ContentPage


	{
        Entry newPasswordEntry;
        DBServices dBServices = new DBServices();
        Entry newEmailEntry;
        public SecurityPage ()
		{
			InitializeComponent ();
            newPasswordEntry = new Entry
            {
                Placeholder = "New Password",
                IsPassword = true
            };

            newEmailEntry = new Entry
            {
                Placeholder = "New Email"
            };

            Button changePasswordButton = new Button
            {
                Text = "Change Password",
                Command = new Command(async () => await ChangePasswordAsync())
            };

            Button changeEmailButton = new Button
            {
                Text = "Change Email",
                Command = new Command(async () => await ChangeEmailAsync())
            };

            // Добавление элементов на страницу
            Content = new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    newPasswordEntry,
                    changePasswordButton,
                    newEmailEntry,
                    changeEmailButton
                }
            };
        }
        private async Task ChangePasswordAsync()
        {
            try
            {
                string newPassword = newPasswordEntry.Text;
                string token = Preferences.Get("token", "");
                await dBServices.ChangePassword(token,newPassword);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to change password: {ex.Message}", "OK");
            }
        }

        private async Task ChangeEmailAsync()
        {
            try
            {
                string newEmail = newEmailEntry.Text;

                await dBServices.ChangeEmail(newEmail); 
              
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to change email: {ex.Message}", "OK");
            }
        }
    }
}
