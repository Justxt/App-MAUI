﻿using App.Pages;

namespace App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pestaña();
        }
    }
}