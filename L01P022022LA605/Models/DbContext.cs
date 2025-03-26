using L01P022022LA605.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {


    }

    public DbSet<Alumnos> Alumnos { get; set; }
    public DbSet<Departamentos> Departamentos { get; set; }
    public DbSet<Facultades> Facultades { get; set; }
    public DbSet<Materias> Materias { get; set; }

}
