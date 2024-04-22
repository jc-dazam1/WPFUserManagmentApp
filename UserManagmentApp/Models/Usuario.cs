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

        // Constructor
        public Usuario(string nombre, string apellido, string documento, string correoElectronico)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            CorreoElectronico = correoElectronico;
            DateTime localDateTime = DateTime.Now; // Fecha y hora local
            DateTime utcDateTime = localDateTime.ToUniversalTime(); // Convertir a UTC
            FechaCreacion = utcDateTime;
        }
    }
}
