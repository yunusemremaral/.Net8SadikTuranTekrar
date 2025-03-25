using Microsoft.EntityFrameworkCore;

namespace razorpagesExample.Models;

public class DataContext:DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-M61UIT9;Database=RazorDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}