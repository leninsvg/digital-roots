using DigitalRoots.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigitalRoots.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<PersonEntity> People { get; set; }
    public DbSet<PeetEntity> Peet { get; set; }
}