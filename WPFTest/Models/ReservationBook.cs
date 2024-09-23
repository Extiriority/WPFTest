using System.Collections.Generic;
using System.Linq;
using WPFTest.Exceptions;

namespace WPFTest.Models
{
    public class ReservationBook
    {
       private readonly List<Reservation> _reservations;

       public ReservationBook()
       {
              _reservations = new List<Reservation>();
       }
       
       public IEnumerable<Reservation> GetAllReservations() => _reservations;
       
       
       public void AddReservation(Reservation reservation)
       {
          foreach (var existingReservation in _reservations.Where(existingReservation => existingReservation.ConflictsWith(reservation)))
          {
             throw new ReservationConflictException(existingReservation, reservation); 
          }

          _reservations.Add(reservation);
       }
    }
}