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
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void PersonInfo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new NavigationPage(new PersonInfoPage()));
        }
        private async void Security_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new SecurityPage()));
        }
        private void Exit_Clicked(object sender, EventArgs e)
        {
            Preferences.Remove("token");
            Navigation.PushModalAsync(new LoginPage());
        }
        private async void deleteAcc_Clicked(object sender, EventArgs e)
        {
            try
            {
                String sol = await DisplayPromptAsync("Удаление аккаунта", "Вы действительно хотите удалить аккаунт?");
                if (sol.ToUpper().Equals("OK"))
                {
                    DBServices dBServices = new DBServices();
                    dBServices.deleteUser(Preferences.Get("token", ""));
                    Preferences.Remove("token");
                    await Navigation.PushModalAsync(new LoginPage());

                }
            }catch(Exception ex)
            {

            }
            
          
        }
    }
}