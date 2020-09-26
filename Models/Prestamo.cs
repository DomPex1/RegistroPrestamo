using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamo.Models
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }        
        public float Concepto { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }

        [ForeignKey("PrestamoId")]
        public virtual List<PrestamoDetalle> PrestamoDetalle { get; set; } = new List<PrestamoDetalle>();

    }

    public class PrestamoDetalle
    {
        [Key]
        public int  Id { get; set; } 
        public int PrestamoId { get; set; }
    }

}