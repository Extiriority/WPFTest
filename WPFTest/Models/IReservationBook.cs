using System.Collections.Generic;

namespace WPFTest.Models
{
    public interface IReservationBook
    {
        IEnumerable<IReservation> GetAllReservations();
        void AddReservation(IReservation reservation);
    }
}