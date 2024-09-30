using System;

namespace WPFTest.Models
{
    public interface IReservation
    {
        RoomID RoomID { get; }
        string Username { get; }
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        TimeSpan Duration { get; }
        bool ConflictsWith(IReservation other);
    }
}