using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamo.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }

        [ForeignKey("PersonaId")]
        public virtual List<PersonasDetalle> PersonasDetalle { get; set; } = new List<PersonasDetalle>();

    }

    public class PersonasDetalle
    {
        [Key]
        public int  Id { get; set; } 
        public int PersonaId { get; set; }
    }
}