using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Semestre { get; set; }
        public int? MateriaId { get; set; }
        public int? CatedraticoId { get; set; }
        public string Horario { get; set; }
        public string Aula { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual Catedratico Catedratico { get; set; }
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
