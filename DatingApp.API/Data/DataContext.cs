using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
  public class DataContext : DbContext
  {
    // pass the options up to DbContext's constructor
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<Value> Values { get; set; }
  }
}