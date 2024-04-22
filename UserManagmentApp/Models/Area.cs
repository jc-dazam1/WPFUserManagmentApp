using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentApp.Models
{
    [Table("Area")]
    public class Area
    {
        //áreas predefinidas
        public static List<Area> AreasPredefinidas { get; private set; }
        // Clave primaria autoincremental
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nombre { get; set; }

        static Area()
        {
            AreasPredefinidas = new List<Area>
            {
                new() { Id = 1, Nombre = "Nómina" },
                new() { Id = 2, Nombre = "Facturación" },
                new() { Id = 3, Nombre = "Servicio al Cliente" }
            };

        }
    }
}
