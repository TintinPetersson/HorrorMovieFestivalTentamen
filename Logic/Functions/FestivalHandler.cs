using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.Functions
{
    public class FestivalHandler
    {
        HorrorMovieContext context = new HorrorMovieContext();
        Regex firstNameRegexValid;
        Regex lastNameRegexValid;
        Regex phoneNumberRegexValid;
        public FestivalHandler()
        {
            //Letters, both upper and lower
            firstNameRegexValid = new Regex(@"^[A-Za-zÅÄÖåäö]{1,18}$");
            //Letters, both upper and lower
            lastNameRegexValid = new Regex(@"^[A-Za-zÅÄÖåäö]{1,18}$");
            //10 minimum digits
            phoneNumberRegexValid = new Regex(@"^([0-9]{10,15})$");
        }

        public Movie GetTickets(Customer customer)
        {
            var tickets = context.Tickets.Where(c => c.CustomerId == customer.Id).FirstOrDefault();
            var movie = tickets.Theater.Movie;
            return movie;
        }
        public Theater GetSpecificTheater(Customer customer)
        {
            var tickets = context.Tickets.Where(C => C.CustomerId == customer.Id).FirstOrDefault();
            var theater = tickets.Theater;
            return theater;
        }
        public bool CheckIfCustomerExists(string phoneNumber)
        {
            var customer = context.Customers.Select(c => c).Where(c => c.PhoneNumber == phoneNumber).FirstOrDefault();

            if (customer!= null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Movie GetMovie(int movieNumber)
        {
            var movie = context.Movies.Where(movie => movie.Id == movieNumber).FirstOrDefault();
            return movie;
        }
        public Customer GetExistingCustomer(string phoneNumber)
        {
            var customer = context.Customers.Select(c => c).Where(c => c.PhoneNumber == phoneNumber).FirstOrDefault();
            return customer;
        }
        public Theater GetTheaters(DateTime dateTime, Movie movie)
        {
            var theater = context.Theaters.Where(theater => theater.StartTime == dateTime && theater.MovieId == movie.Id).FirstOrDefault();
            return theater;
        }
        public void ChangeCustomerTickets(Theater theater, Customer customer, int tickets)
        {
            theater.OccupiedSeats = theater.OccupiedSeats - customer.Tickets.Count;

            var ticketsToRemove = context.Tickets.Where(c => c.CustomerId == customer.Id).ToList();

            foreach (var item in ticketsToRemove)
            {
                context.Tickets.Remove(item);
            }

            customer.Tickets.Clear();
            var newCustomer = new Customer(customer);
            context.Customers.Remove(customer);
            context.Customers.Add(newCustomer);

            for (int i = 0; i < tickets; i++)
            {
                theater.OccupiedSeats += 1;
                newCustomer.Tickets.Add(new Ticket { TheaterId = theater.Id, CustomerId = customer.Id, Seat = theater.OccupiedSeats, Wheelchair = theater.GotWheelchairRamp });
            }

            context.SaveChanges();
        }
        public Theater GetTheatersWheelChair(DateTime dateTime, Movie movie)
        {
            var theater = context.Theaters.Where(theater => theater.StartTime == dateTime && theater.MovieId == movie.Id && theater.GotWheelchairRamp == true).FirstOrDefault();
            return theater;
        }
        public bool FirstNameValid(string firstName)
        {
            if (firstNameRegexValid.IsMatch(firstName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LastNameValid(string lastName)
        {
            if (lastNameRegexValid.IsMatch(lastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PhoneNumberValid(string phoneNumber)
        {
            if (phoneNumberRegexValid.IsMatch(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Customer GetNewCustomer(string firstName, string lastName, string phoneNumber, int ticketAmount, Theater theater)
        {
            var customer = new Customer { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber };

            for (int i = 0; i < ticketAmount; i++)
            {
                theater.OccupiedSeats += 1;
                customer.Tickets.Add(new Ticket { TheaterId = theater.Id, CustomerId = customer.Id, Seat = theater.OccupiedSeats, Wheelchair = theater.GotWheelchairRamp });
            }

            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }
    }
}
