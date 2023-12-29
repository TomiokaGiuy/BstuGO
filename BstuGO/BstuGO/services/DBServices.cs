using BstuGO.models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Database.Query;
using Firebase.Auth;

namespace BstuGO.services
{
    public class DBServices
    {
        FirebaseClient client;
        FirebaseAuthProvider authProvider;
        string WebApiKey = "AIzaSyD1zRE3Zsu6RA3s-aVZqnvoXBxWv_pSifA";
        public DBServices()
        {
            client = new FirebaseClient("https://bstugo-2878e-default-rtdb.europe-west1.firebasedatabase.app/");
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebApiKey));
        }


        public async Task<bool> Register(string email,string password)
        {
            var token = await authProvider.CreateUserWithEmailAndPasswordAsync(email,password);
            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return true;
            }
            return false;
        }

        public async Task<string> SignIn(string email, string password)
        {
            var token = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return token.FirebaseToken;
            }
            return "";
        }

        public async Task addUsers(string login,string password)
        {
            models.User user = new models.User()
            {
                Login = login,
                Password = password
            };
            await client.Child("Users").PostAsync(user);
            
        }
    }
}