using Microsoft.EntityFrameworkCore;
using Selu383.SP24.Api.Entity;
using System.Collections.Generic;
public class DataContext : DbContext
{
    public DbSet<Hotel> Hotel { get; set; }

    public DataContext(DbContextOptions<DataContext> options)
    : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed data for the Hotel entity
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel { Id = 5, Name = "Hotel A", Address = "Location A" },
            new Hotel { Id = 6, Name = "Hotel B", Address = "Location B" }
            // Add more hotels as needed
        );

        // You can seed data for other entities in a similar manner if needed
        
        base.OnModelCreating(modelBuilder);
    }
    
}
