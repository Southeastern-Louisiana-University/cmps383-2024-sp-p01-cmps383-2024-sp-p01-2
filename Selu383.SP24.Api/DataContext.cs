using Microsoft.EntityFrameworkCore;
using Selu383.SP24.Api.Entity;
using System.Collections.Generic;
public class DataContext : DbContext
{
    public DbSet<Hotel> Hotel { get; set; }

    public void SeedData()
    {
        if (Hotel.Any())
        {
            Hotel.AddRange(
                new Hotel {  Name = "Hotel A", Address = "Location A" },
                new Hotel { Name = "Hotel B", Address = "Location B" },
                new Hotel { Name = "Hotel C", Address = "Location C" }
                // Add more hotels as needed
            );

            SaveChanges();
        }
    }

    public DataContext(DbContextOptions<DataContext> options)
   : base(options)
    {

    }

}
