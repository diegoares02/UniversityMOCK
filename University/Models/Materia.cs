using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public int Nro_Creditos { get; set; }
        public int? CarreraId { get; set; }
        public virtual Carrera Carrera { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}
