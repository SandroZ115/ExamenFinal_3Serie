using Microsoft.EntityFrameworkCore;

public class CRUD_AlumnosContext(DbContextOptions<CRUD_AlumnosContext> options) : DbContext(options)
{
    public DbSet<CrudAlumnos.Models.Alumno> Alumno { get; set; } = default!;
}
