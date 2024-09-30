using System.Collections.Generic;
using WPFTest.Exceptions;

namespace WPFTest.Models
{
    public class Hotel : IHotel
    {
        private readonly IReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<IReservation> GetAllReservations() => _reservationBook.GetAllReservations();
        public void AddReservation(IReservation reservation) => _reservationBook.AddReservation(reservation);
    }
}