using System.Collections.Generic;
using WPFTest.Exceptions;

namespace WPFTest.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        
        public string Name { get; }
        
        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }
        
        /// <summary>
        /// Get a Reservation for a user
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns></returns>
        public IEnumerable<Reservation> GetAllReservations() => 
            _reservationBook.GetAllReservations();

        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation">The incoming reservation</param>
        /// <exception cref="ReservationConflictException"></exception>
        public  void AddReservation(Reservation reservation) =>
            _reservationBook.AddReservation(reservation);
        
    }
}