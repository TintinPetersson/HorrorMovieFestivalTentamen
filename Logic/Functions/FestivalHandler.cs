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
        public Movie GetMovie(int movieNumber)
        {
            var movie = context.Movies.Where(movie => movie.Id == movieNumber).FirstOrDefault();
            return movie;
        }
        public Theater GetTheaters(DateTime dateTime, Movie movie)
        {
            var theater = context.Theaters.Where(theater => theater.StartTime == dateTime && theater.MovieId == movie.Id).FirstOrDefault();
            return theater;
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
    }
}
