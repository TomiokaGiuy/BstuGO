using BstuGO.models;
using BstuGO.services;
using BstuGO.views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BstuGO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Schedule : ContentPage
    {
        WebView webView;
        string course = "1";

        DBServices srv = new DBServices();
        public Schedule()
        {


            InitializeComponent();



            getCourse();

        }
        public async void getCourse()
        {
            string email = Preferences.Get("email", "");
            Student std = await srv.GetStudent(email);
            course = std.Course;
            string path = await srv.GetFile($"ФЭИС-1.pdf");
            var webView = new WebView
            {

                Source = new UrlWebViewSource
                {


                    //Url = $"https://mozilla.github.io/pdf.js/web/viewer.html?file={path}",
                    Url = $"https://docs.google.com/gview?embedded=true&url=https://feis.bstu.by/wp-content/uploads/2023/08/ФЭИС-{course}.pdf",
                },
                VerticalOptions = LayoutOptions.FillAndExpand

            };
            Content = webView;
        }
    }
}