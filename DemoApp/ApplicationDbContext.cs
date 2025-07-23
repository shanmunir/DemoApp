using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Example entity sets:
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    // Add your other DbSets here

    // Optional: configure model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Example configuration:
        modelBuilder.Entity<WeatherForecast>()
            .HasKey(w => w.Id);
    }
}

// Sample entity
public class WeatherForecast
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }
    public string WeatherType { get; set; }
}
