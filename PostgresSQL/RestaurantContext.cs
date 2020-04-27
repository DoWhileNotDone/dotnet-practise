using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.PostgresSQL 
{
    public class RestaurantContext : DbContext
    {
            public DbSet<Restaurant> Restaurants { get; set; }
            public RestaurantContext(DbContextOptions<RestaurantContext> options)
                : base(options)
            { }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
                => optionsBuilder.UseNpgsql("Host=postgres;Database=mydb;Username=myuser;Password=mypass");
    }
}
