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

        public ReservationListingViewModel(IReservationBook reservationBook)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            foreach (var reservation in reservationBook.GetAllReservations())
            {
                _reservations.Add(new ReservationViewModel(reservation));
            }

            // Add fake data
            _reservations.Add(new ReservationViewModel(
                new Reservation(
                    new RoomID(1, 1),
                    "Alice",
                    new DateTime(2021, 3, 30, 9, 0, 0, DateTimeKind.Local),
                    new DateTime(2021, 4, 30, 10, 0, 0, DateTimeKind.Local)
                )
            ));
            _reservations.Add(new ReservationViewModel(
                new Reservation(
                    new RoomID(1, 2),
                    "Bob",
                    new DateTime(2021, 8, 12, 10, 0, 0, DateTimeKind.Local),
                    new DateTime(2021, 8, 24, 11, 0, 0, DateTimeKind.Local)
                )
            ));
            _reservations.Add(new ReservationViewModel(
                new Reservation(
                    new RoomID(2, 2),
                    "Charlie",
                    new DateTime(2022, 7, 5, 9, 0, 0, DateTimeKind.Local),
                    new DateTime(2022, 7, 12, 10, 0, 0, DateTimeKind.Local)
                )
            ));
        }
    }
}