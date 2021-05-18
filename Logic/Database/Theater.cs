using System;
using System.Collections.Generic;

namespace Logic
{
    public class Theater
    {
        public int Id { get; set; }
        public virtual Movie Movie { get; set; }
        public int? MovieId { get; set; }
        public int RoomNumber { get; set; }
        public DateTime? StartTime { get; set; }
        public bool GotWheelchairRamp { get; set; }
        public int TotalSeats { get; set; }
        public int SeatsLeft { get => TotalSeats - OccupiedSeats; }
        public int OccupiedSeats { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public Theater()
        {
            TotalSeats = 20;
        }
    }
}