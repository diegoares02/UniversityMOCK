using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Catedratico
    {
        public int CatedraticoId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}
