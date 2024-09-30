using System;
using WPFTest.Models;

namespace WPFTest.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly IReservation _reservation;

        public string RoomID => _reservation.RoomID?.ToString();
        public string Username => _reservation.Username;
        public string StartDate => _reservation.StartTime.ToString("d");
        public string EndDate => _reservation.EndTime.ToString("d");

        public ReservationViewModel(IReservation reservation)
        {
            _reservation = reservation;
        }
    }
}