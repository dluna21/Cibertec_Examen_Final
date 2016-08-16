using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebExamenFinal.Model
{
    [Table("dbo.Autores")]
    public class Autores
    {
        [Key]
        public int au_id { get; set; }
        [Required]
        [StringLength(200)]
        public string au_INombre { get; set; }
        [Required]
        [StringLength(200)]
        public string au_fNombre { get; set; }

        public string au_telefono { get; set; }
        public string au_ciudad { get; set; }
        public string au_estado { get; set; }
        public string au_zip { get; set; }
        public string au_sexo { get; set; }
        public float au_salario { get; set; }
        public string au_tema { get; set; }
    }
}
