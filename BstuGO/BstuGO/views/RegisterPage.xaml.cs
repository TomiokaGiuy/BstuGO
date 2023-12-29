using BstuGO.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BstuGO.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

	public partial class RegisterPage : ContentPage
	{
		DBServices services = new DBServices();
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        private async void btnReg_Clicked(object sender, EventArgs e)
        {
			try
			{
                string email = UserEmailEntry.Text;
                string password = PasswordEntry.Text;
                string replyPassword = repeatPasswordEntry.Text;
                string name = UserNamelEntry.Text;


                if (!replyPassword.Equals(password))
                {
                    await DisplayAlert("Регистрация", "Повторный пароль не совпадает с основным", "OK");
                }
                else
                {
                    bool isSave = await services.Register(email, password);
                    if (isSave)
                    {

                        await DisplayAlert("Регистрация", "Регистрация завершена успешно", "ok");
                    }
                }
                
            }
            catch(Exception ex)
			{
                if (ex.Message.Contains("EMAIL_EXISTS"))
                {
                    await DisplayAlert("Регистрация", "Данный email уже зарегистрован", "OK");
                }else if (ex.Message.Contains("WEAK_PASSWORD"))
                {
                    await DisplayAlert("Регистрация", "Пароль должен быть больше или равен 6 символам", "OK");
                }
                else
                {
                    await DisplayAlert("Регистрация", ex.Message, "OK");
                }
               
            }
        }

        private async void Label_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

    }
}