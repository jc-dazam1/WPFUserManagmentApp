using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentApp.Models
{
    public class Usuario
    {
        // Propiedades del usuario
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string CorreoElectronico { get; set; }

        // Constructor
        public Usuario(string nombre, string apellido, string documento, string correoElectronico)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            CorreoElectronico = correoElectronico;
        }
    }
}
