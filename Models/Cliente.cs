using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace webpita.Models
{
    [Table ("Clientes")]
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int No_parte { get; set; }

        public string Foto { get; set; } = "";

        public virtual Proveedor Proveedor { get; set; }
    }
}
