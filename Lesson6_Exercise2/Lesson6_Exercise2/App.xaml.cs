﻿using Lesson6_Exercise2.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson6_Exercise2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            View.MainPage person = new View.MainPage();
            PersonViewModel personViewModel = new PersonViewModel();
            person.DataContext = personViewModel;
            person.Show();
        }
    }
}
