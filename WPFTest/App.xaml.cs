using System;
using System.Collections.Generic;
using System.Windows;
using WPFTest.Exceptions;
using WPFTest.Models;
using WPFTest.ViewModels;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            
                MainWindow = new MainWindow
                {
                    DataContext = new MainViewModel()
                };
                MainWindow.Show();
            
            
            
            base.OnStartup(e);
        }
    }
}