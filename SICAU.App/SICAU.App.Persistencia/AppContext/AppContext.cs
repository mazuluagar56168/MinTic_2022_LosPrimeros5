using Microsoft.EntityFrameworkCore;
using SICAU.App.Dominio;

namespace SICAU.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Encuesta> encuestas { get; set; }
        public DbSet<Horario> horarios { get; set; }
        public DbSet<Sede> sedes { get; set; }
        public DbSet<Persona> personas { get; set; }
        public DbSet<PersonalAseo> personalAseos { get; set; }
        public DbSet<Profesor> profesores { get; set; }
        public DbSet<Directivo> directivos { get; set; }
        public DbSet<Estudiante> estudiantes { get; set; }
        public DbSet<Materia> materias { get; set; }
        public DbSet<Salon> salones { get; set; }
        public DbSet<Sintoma> sintomas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SICAUData");
            }
        }
    }
}