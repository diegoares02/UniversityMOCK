using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Carrera
    {
        [Key]
        public int CarreraId { get; set; }
        public string Nombre { get; set; }
        public int NroMaterias { get; set; }
        public ICollection<Materia> Materias { get; set; }
    }
}
