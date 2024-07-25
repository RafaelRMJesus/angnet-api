using angnet_api.Models;
using Microsoft.EntityFrameworkCore;

namespace angnet_api.Data
{
  public class AppDbContext:DbContext 
  {
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {

    }

    public DbSet<Student> Students { get; set; }
  }
}