﻿using System;

namespace WPFTest.Models
{
    public class Reservation
    {
       public RoomID RoomID { get; }
       public string Username { get;}
       public DateTime StartTime { get; }
       public DateTime EndTime { get; }
       public TimeSpan Duration => EndTime - StartTime;

       public Reservation(RoomID roomId, string username, DateTime startTime, DateTime endTime)
       {
            RoomID = roomId; 
            Username = username; 
            StartTime = startTime; 
            EndTime = endTime;
       }
       
       public bool ConflictsWith(Reservation other)
       {
           return RoomID.Equals(other.RoomID) && 
                  StartTime < other.EndTime && EndTime > other.StartTime;
       }
    }
}