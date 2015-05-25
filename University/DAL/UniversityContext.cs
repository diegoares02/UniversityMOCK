using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace University.DAL
{
    public class UniversityContext : DbContext
    {
        public UniversityContext()
            : base("UniversityContext")
        { }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<Catedratico> Catedraticos { get; set; }
        public virtual DbSet<Inscripcion> Inscripciones { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Nota> Notas { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
