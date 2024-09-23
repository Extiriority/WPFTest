using System;
using System.Collections.Generic;
using System.Windows;
using WPFTest.Exceptions;
using WPFTest.Models;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Giangs Delightful Hotel");
            
            
                hotel.AddReservation(new Reservation(
                    new RoomID(1, 101),
                    "giang",
                    new DateTime(2021, 1, 1),
                    new DateTime(2021, 1, 3)));

                hotel.AddReservation(new Reservation(
                    new RoomID(1, 101),
                    "giang",
                    new DateTime(2021, 1, 4),
                    new DateTime(2021, 1, 7)));
                
                
            IEnumerable<Reservation> reservations = hotel.GetAllReservations();
            
            base.OnStartup(e);
            //var mainWindow = new MainWindow();
            //mainWindow.Show();
        }
    }
}