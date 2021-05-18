using Microsoft.EntityFrameworkCore;
using System;

namespace Logic
{
    public class HorrorMovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=HorrorMovieDatabase;Trusted_Connection=True;")
                    .UseLazyLoadingProxies();
            }
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Check if data exists, else add the data
            modelBuilder.Entity<Movie>().HasData
                (
                new Movie
                {
                    Id = 1,
                    Name = "Psycho",
                    Info = "A Phoenix secretary embezzles $40,000 from " +
                    "her employer's client, goes on the run, and checks into " +
                    "a remote motel run by a young man " +
                    "under the domination of his mother. ",
                    PicturePath = "Psycho - Poster.jpg"
                },
                new Movie
                {
                    Id = 2,
                    Name = "Get Out",
                    Info = "A young African-American visits his white " +
                    "girlfriend's parents for the weekend, " +
                    "where his simmering uneasiness about their reception of " +
                    "him eventually reaches a boiling point. ",
                    PicturePath = "Get Out - Poster.jpg"
                },
                new Movie
                {
                    Id = 3,
                    Name = "Us",
                    Info = "A family's serene beach vacation turns to chaos when " +
                    "their doppelgängers appear and begin to terrorize them.",
                    PicturePath = "Us - Poster.jpg"
                },
                 new Movie
                 {
                     Id = 4,
                     Name = "Alien",
                     Info = "After a space merchant vessel receives " +
                     "an unknown transmission as a distress call, " +
                     "one of the crew is attacked by a mysterious life form " +
                     "and they soon realize that its life cycle has merely begun. ",
                     PicturePath = "Alien - Poster.jpg"
                 },
                  new Movie
                  {
                      Id = 5,
                      Name = "The Invisible Man",
                      Info = "When Cecilia's abusive ex takes his own " +
                      "life and leaves her his fortune, " +
                      "she suspects his death was a hoax. As a series of " +
                      "coincidences turn lethal, " +
                      "Cecilia works to prove that she is being hunted by " +
                      "someone nobody can see. ",
                      PicturePath = "The Invisible Man - Poster.jpg"
                  },
                  new Movie
                  {
                      Id = 6,
                      Name = "A Quiet Place",
                      Info = "In a post-apocalyptic world, a family is forced to " +
                      "live in silence while hiding from monsters with ultra-sensitive hearing. ",
                      PicturePath = "A Quiet Place - Poster.jpg"
                  },
                  new Movie
                  {
                      Id = 7,
                      Name = "Jaws",
                      Info = "When a killer shark unleashes chaos on a " +
                      "beach community, it's up to a local sheriff, " +
                      "a marine biologist, and an old seafarer to hunt the " +
                      "beast down. ",
                      PicturePath = "Jaws - Poster.jpg"
                  },
                   new Movie
                   {
                       Id = 8,
                       Name = "The Babadook",
                       Info = "A single mother and her child fall into a deep " +
                       "well of paranoia when an eerie children's " +
                       "book titled Mister Babadook manifests in their home. ",
                       PicturePath = "The Babadook - Poster.jpg"
                   },
                   new Movie
                   {
                       Id = 9,
                       Name = "Hereditary",
                       Info = "A grieving family is haunted by tragic " +
                       "and disturbing occurrences. ",
                       PicturePath = "Hereditary - Poster.jpg"
                   },
                   new Movie
                   {
                       Id = 10,
                       Name = "Let the right one in",
                       Info = "Oskar, an overlooked and bullied boy, " +
                       "finds love and revenge through Eli, a beautiful " +
                       "but peculiar girl. ",
                       PicturePath = "Let the Right One In - Poster.jpg"
                   }
                );

            modelBuilder.Entity<Theater>().HasData(
                //20-22:00 Pass
                new Theater { Id = 1, RoomNumber = 1, MovieId = 1, StartTime = new DateTime (2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 2, RoomNumber = 2, MovieId = 2, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 3, RoomNumber = 3, MovieId = 3, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 4, RoomNumber = 4, MovieId = 4, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 5, RoomNumber = 5, MovieId = 5, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 6, RoomNumber = 6, MovieId = 6, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 7, RoomNumber = 7, MovieId = 7, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 8, RoomNumber = 8, MovieId = 8, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 9, RoomNumber = 9, MovieId = 9, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = true },
                new Theater { Id = 10, RoomNumber = 10, MovieId = 10, StartTime = new DateTime(2021, 06, 22, 20, 00, 00), GotWheelchairRamp = true },

                //22-00:00 Pass
                new Theater { Id = 11, RoomNumber = 1, MovieId = 10, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 12, RoomNumber = 2, MovieId = 9, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 13, RoomNumber = 3, MovieId = 8, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 14, RoomNumber = 4, MovieId = 7, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 15, RoomNumber = 5, MovieId = 6, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 16, RoomNumber = 6, MovieId = 5, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 17, RoomNumber = 7, MovieId = 4, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 18, RoomNumber = 8, MovieId = 3, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 19, RoomNumber = 9, MovieId = 2, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = true },
                new Theater { Id = 20, RoomNumber = 10, MovieId = 1, StartTime = new DateTime(2021, 06, 22, 22, 00, 00), GotWheelchairRamp = true },

                //00-02:00 Pass
                new Theater { Id = 21, RoomNumber = 1, MovieId = 8, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 22, RoomNumber = 2, MovieId = 7, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 23, RoomNumber = 3, MovieId = 10, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 24, RoomNumber = 4, MovieId = 9, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 25, RoomNumber = 5, MovieId = 6, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 26, RoomNumber = 6, MovieId = 5, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 27, RoomNumber = 7, MovieId = 2, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 28, RoomNumber = 8, MovieId = 1, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 29, RoomNumber = 9, MovieId = 4, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = true },
                new Theater { Id = 30, RoomNumber = 10, MovieId = 3, StartTime = new DateTime(2021, 06, 23, 00, 00, 00), GotWheelchairRamp = true },

                //02-04:00 Pass
                new Theater { Id = 31, RoomNumber = 1, MovieId = 3, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 32, RoomNumber = 2, MovieId = 4, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 33, RoomNumber = 3, MovieId = 9, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 34, RoomNumber = 4, MovieId = 2, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 35, RoomNumber = 5, MovieId = 1, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 36, RoomNumber = 6, MovieId = 8, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 37, RoomNumber = 7, MovieId = 7, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 38, RoomNumber = 8, MovieId = 10, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = false },
                new Theater { Id = 39, RoomNumber = 9, MovieId = 6, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = true },
                new Theater { Id = 40, RoomNumber = 10, MovieId = 5, StartTime = new DateTime(2021, 06, 23, 02, 00, 00), GotWheelchairRamp = true }
                );
         }           
    }
}
