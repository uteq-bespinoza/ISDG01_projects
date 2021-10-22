﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            
            Navigation = MainPage.Navigation;
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
