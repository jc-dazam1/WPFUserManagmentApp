using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserManagmentApp.Models
{
    public class Area
    {
        //áreas predefinidas
        public static List<Area> AreasPredefinidas { get; private set; }

        // Clave primaria autoincremental
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        static Area()
        {
            AreasPredefinidas = new List<Area>
            {
                new Area { Id = 1, Nombre = "Nómina" },
                new Area { Id = 2, Nombre = "Facturación" },
                new Area { Id = 3, Nombre = "Servicio al Cliente" }
            };

        }
    }
}
