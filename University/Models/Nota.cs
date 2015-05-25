using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Nota
    {
        [Key]
        public int NotaId { get; set; }
        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int TercerParcial { get; set; }
        public int CuartoParcial { get; set; }
        public int NotaFinal { get; set; }
        public string Estado { get; set; }
        public int? InscripcionId { get; set; }
        public virtual Inscripcion Inscripcion { get; set; }
    }
}
