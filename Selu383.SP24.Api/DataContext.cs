using Microsoft.EntityFrameworkCore;
using Selu383.SP24.Api.Entity;
using System.Collections.Generic;
public class DataContext : DbContext
{
    public DbSet<Hotel> Hotels { get; set; }

    public DataContext(DbContextOptions<DataContext> options)
    : base(options)
    {

    }
}
