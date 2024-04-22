using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentApp.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        // Clave primaria autoincremental
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public long AreaId { get; set; } // Clave foránea para la relación con Área
        public Area Area { get; set; } // Propiedad de navegación para acceder al Área asociada

        // Constructor
        public Usuario(string nombre, string apellido, string documento, string correoElectronico, long areaId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            CorreoElectronico = correoElectronico;
            AreaId = areaId; // Asigna el Id del Área
            DateTime localDateTime = DateTime.Now; // Fecha y hora local
            DateTime utcDateTime = localDateTime.ToUniversalTime(); // Convertir a UTC
            FechaCreacion = utcDateTime;
        }
    }
}
