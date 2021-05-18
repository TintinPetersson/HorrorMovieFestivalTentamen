using System.Collections.Generic;

namespace Logic
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public Customer()
        {
            Tickets = new List<Ticket>();
        }
    }
}