﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trabalho_App_Read_Sms_Code
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
