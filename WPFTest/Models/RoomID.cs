using System;
namespace WPFTest.Models
{
    public class RoomID
    {
        public  int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}-{RoomNumber}";
        }

        public override bool Equals(object obj) {
            return obj is RoomID id &&
                   FloorNumber == id.FloorNumber &&
                   RoomNumber == id.RoomNumber;
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + FloorNumber.GetHashCode();
                hash = hash * 23 + RoomNumber.GetHashCode();
                return hash;
            }
        }
    }
}