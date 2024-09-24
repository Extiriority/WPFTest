using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPFTest.Models;

namespace WPFTest.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
 
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }
        
        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 1), "Alice", new DateTime(2021, 1, 1, 9, 0, 0), new DateTime(2021, 1, 1, 10, 0, 0))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "Bob", new DateTime(2021, 1, 1, 10, 0, 0), new DateTime(2021, 1, 1, 11, 0, 0))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 2), "Charlie", new DateTime(2021, 1, 1, 9, 0, 0), new DateTime(2021, 1, 1, 10, 0, 0))));
        }
    }
}