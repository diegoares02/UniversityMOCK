using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public int Telefono { get; set; }
        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
