namespace Logic
{
    public class Ticket
    {
        public int Id { get; set; }
        public virtual Theater Theater { get; set; }
        public int TheaterId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public int Seat { get; set; }
        public bool Wheelchair { get; set; }
    }
}