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
			string email = TxtEmail.Text;
			string password = TxtPswrd.Text;
			bool isSave = await services.Register(email, password);
			if (isSave)
			{
				await DisplayAlert("Register user", "Reg compl", "ok");
			}
			else
			{
                await DisplayAlert("Register user", "Reg failed", "ok");
            }
        }

	
    }
}