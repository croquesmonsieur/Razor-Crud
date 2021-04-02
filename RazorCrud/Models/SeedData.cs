using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorCrud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudClimberContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudClimberContext>>()))
            {
                // Look for any movies.
                if (context.Climber.Any())
                {
                    return;   // DB has been seeded
                }

                context.Climber.AddRange(
                    new Climber()
                    {
                        ClimberName = "Chris Sharma",
                        Date = DateTime.Parse("1981-04-23"),
                        Country = "Santa Cruz, California, USA",
                        Style = "Lead climbing",
                        FavoritePlace = "Catalonia, Spain",
                        Achievement = "Alasha 9b"
                    },

                    new Climber()
                    {
                        ClimberName = "Tommy Caldwell",
                        Date = DateTime.Parse("1978-08-21"),
                        Country = "Innsbruck, Austria",
                        Style = "Adam Ondra",
                        FavoritePlace = "Manon Hilly",
                        Achievement = "Manon Hilly"
                    },

                    new Climber()
                    {
                        ClimberName = "Carolynn Marie Hill",
                        Date = DateTime.Parse("1961-01-03"),
                        Country = "Innsbruck, Austria",
                        Style = "Adam Ondra",
                        FavoritePlace = "Manon Hilly",
                        Achievement = "Manon Hilly"
                    },

                    new Climber()
                    {
                        ClimberName = "IFSC Climbing World Cup",
                        Date = DateTime.Parse("1990-01-01"),
                        Country = "Innsbruck, Austria",
                        Style = "Adam Ondra",
                        FavoritePlace = "Manon Hilly",
                        Achievement = "Manon Hilly"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}