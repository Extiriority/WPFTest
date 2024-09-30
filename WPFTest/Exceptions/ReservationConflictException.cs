using System;
using System.Runtime.Serialization;
using WPFTest.Models;

namespace WPFTest.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public IReservation ExistingReservation { get; }
        public IReservation IncomingReservation { get; }
        public ReservationConflictException(IReservation existingReservation, IReservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string message, IReservation existingReservation, IReservation incomingReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string message, Exception innerException, IReservation existingReservation, IReservation incomingReservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        protected ReservationConflictException(SerializationInfo info, StreamingContext context, IReservation existingReservation, IReservation incomingReservation) : base(info, context)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }
    }
}