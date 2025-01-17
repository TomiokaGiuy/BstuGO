﻿using BstuGO.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BstuGO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void News_Button(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewsPage());
        }

        private async void Schedule_Class_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Schedule());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private async void Profile_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewsPage());
        }

        private async void Maps_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Maps());
        }
    }
}
