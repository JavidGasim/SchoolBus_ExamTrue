using Microsoft.EntityFrameworkCore;
using SchoolBus_Model.Entities.Concrete;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Design;

namespace SchoolBus_DataAccess.Contexts;

public class SchoolBusDB : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Data Source=DESKTOP-3HBTQMT\\SQLEXPRESS01;Initial Catalog=SchoolBusDBTrue;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
       
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<Class> Classes { get; set; }
    public virtual DbSet<Driver> Drivers { get; set; }
    public virtual DbSet<Parent> Parents { get; set; }
    public virtual DbSet<Ride> Rides { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Admin> Admins{ get; set; }
}
