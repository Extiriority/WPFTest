using System.Collections.Generic;
using System.Linq;
using WPFTest.Exceptions;

namespace WPFTest.Models
{
    public class ReservationBook : IReservationBook
    {
       private readonly List<IReservation> _reservations = new List<IReservation>();

       public IEnumerable<IReservation> GetAllReservations() => _reservations;

       public void AddReservation(IReservation reservation)
       {
          if (_reservations.Exists(existingReservation => existingReservation.ConflictsWith(reservation)))
          {
             var conflictingReservation = _reservations.First(existingReservation => existingReservation.ConflictsWith(reservation));
             throw new ReservationConflictException(conflictingReservation, reservation);
          }

          _reservations.Add(reservation);
       }
    }
}