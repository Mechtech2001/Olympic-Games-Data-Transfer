using Microsoft.EntityFrameworkCore;

namespace Olympic_Games_Data_Transfer.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext (DbContextOptions<CountryContext> options) : base(options) { }
        
        public DbSet<Country> Countrys { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Sport> Sports { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Event>().HasData(
                new Event { EventID = "summer olympics", EventName = "Summer Olympics" },
                new Event { EventID = "winter olympics", EventName = "Winter Olympics" },
                new Event { EventID = "paralympics", EventName = "Paralympic Games"},
                new Event { EventID = "youth olympics", EventName = "Youth Olympic Games"}
                );

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curling", SportName = "Curling", category = "Indoor"},
                new Sport { SportID = "bobsleigh", SportName = "Bobsleigh", category = "Outdoor" },
                new Sport { SportID = "diving", SportName = "Diving", category = "Indoor" },
                new Sport { SportID = "cycling", SportName = "Cycling", category = "Outdoor" },
                new Sport { SportID = "archery", SportName = "Archery", category = "Indoor" },
                new Sport { SportID = "canoe sprint", SportName = "Canoe Sprint", category = "Outdoor" },
                new Sport { SportID = "breakdancing", SportName = "Breakdancing", category = "Indoor" },
                new Sport { SportID = "skatebording", SportName = "Skatebording", category = "Outdoor" }
                );

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "canada", CountryName = "Canada", EventID = "winter olympics", SportID = "curling", flag = "canada.png" },
                new { CountryID = "sweden", CountryName = "Sweden", EventID = "winter olympics", SportID = "curling", flag = "sweden.png" },
                new { CountryID = "britain", CountryName = "Great Britain", EventID = "winter olympics", SportID = "curling", flag = "britain.png" },
                new { CountryID = "jamaica", CountryName = "Jamaica", EventID = "winter olympics", SportID = "bobsleigh", flag = "jamaica.png" },
                new { CountryID = "italy", CountryName = "Italy", EventID = "winter olympics", SportID = "bobsleigh", flag = "italy.png" },
                new { CountryID = "japan", CountryName = "Japan", EventID = "winter olympics", SportID = "bobsleigh", flag = "japan.png" },
                new { CountryID = "germany", CountryName = "Germany", EventID = "summer olympics", SportID = "diving", flag = "germany.png" },
                new { CountryID = "china", CountryName = "China", EventID = "summer olympics", SportID = "diving", flag = "china.png" },
                new { CountryID = "mexico", CountryName = "Mexico", EventID = "summer olympics", SportID = "diving", flag = "mexico.png" },
                new { CountryID = "brazil", CountryName = "Brazil", EventID = "summer olympics", SportID = "cycling", flag = "brazil.png" },
                new { CountryID = "netherlands", CountryName = "Netherlands", EventID = "summer olympics", SportID = "cycling", flag = "netherlands.png" },
                new { CountryID = "usa", CountryName = "USA", EventID = "summer olympics", SportID = "cycling", flag = "usa.png" },
                new { CountryID = "thailand", CountryName = "Thailand", EventID = "paralympics", SportID = "archery", flag = "thailand.png" },
                new { CountryID = "uruguay", CountryName = "Uruguay", EventID = "paralympics", SportID = "archery", flag = "uruguay.png" },
                new { CountryID = "ukraine", CountryName = "Ukraine", EventID = "paralympics", SportID = "archery", flag = "ukraine.png" },
                new { CountryID = "austria", CountryName = "Austria", EventID = "paralympics", SportID = "canoe sprint", flag = "austria.png" },
                new { CountryID = "pakistan", CountryName = "Pakistan", EventID = "paralympics", SportID = "canoe sprint", flag = "pakistan.png" },
                new { CountryID = "zimbabwe", CountryName = "Zimbabwe", EventID = "paralympics", SportID = "canoe sprint", flag = "zimbabwe.png" },
                new { CountryID = "france", CountryName = "France", EventID = "youth olympics", SportID = "breakdancing", flag = "france.png" },
                new { CountryID = "cyprus", CountryName = "Cyprus", EventID = "youth olympics", SportID = "breakdancing", flag = "cyprus.png" },
                new { CountryID = "russia", CountryName = "Russia", EventID = "youth olympics", SportID = "breakdancing", flag = "russia.png" },
                new { CountryID = "finland", CountryName = "Finland", EventID = "youth olympics", SportID = "skatebording", flag = "finland.png" },
                new { CountryID = "slovakia", CountryName = "Slovakia", EventID = "youth olympics", SportID = "skatebording", flag = "slovakia.png" },
                new { CountryID = "portugal", CountryName = "Portugal", EventID = "youth olympics", SportID = "skatebording", flag = "portugal.png" }
                );
        }
    }
}
