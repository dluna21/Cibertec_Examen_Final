using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebExamenFinal.Model
{
    [Table("dbo.Libros")]
    public class Libros
    {
        [Key]
        public int titulo_id { get; set; }

        [Required]
        [StringLength(200)]
        public string titulo { get; set; }
        public string tipo { get; set; }

        public int pub_id { get; set; }

        [Required]
        public float precio { get; set; }
        public bool avanzado { get; set; }

        public bool realeza { get; set; }
        public int ytd_ventas { get; set; }

        public string notas { get; set; }

         
    }
}
