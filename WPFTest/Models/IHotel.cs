using System.Collections.Generic;

namespace WPFTest.Models
{
    public interface IHotel
    {
        string Name { get; }
        IEnumerable<IReservation> GetAllReservations();
        void AddReservation(IReservation reservation);
    }
}