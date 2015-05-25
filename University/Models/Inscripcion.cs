using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        public int? StudentId { get; set; }
        public int? CursoId { get; set; }
        public DateTime Fecha_Inscripcion { get; set; }//? sirve para permitir nullable
        public virtual Student Student { get; set; }//especifica un solo estudiante
        public virtual Curso Curso { get; set; }
        public ICollection<Nota> Notas { get; set; }
    }
}
