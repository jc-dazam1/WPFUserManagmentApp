using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentApp.Models;

namespace UserManagmentApp.Controllers
{
    public class UsuarioController
    {
        private AppDbContext dbContext; // Contexto de la base de datos

        public UsuarioController()
        {
            dbContext = new AppDbContext(); // Inicializa el contexto de la base de datos con las opciones de configuración
        
        }

         // Método para guardar un nuevo usuario en la bd
        public void GuardarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                dbContext.Usuarios.Add(nuevoUsuario); // Agrega el nuevo usuario al contexto
                dbContext.SaveChanges(); // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el usuario: " + ex.Message);
            }
        }

        // Método para obtener una lista de los últimos 10 usuarios creados
        public List<Usuario> ObtenerUltimosUsuarios()
        {
            try
            {
                // Consulta los últimos 10 usuarios ordenados por fecha de creación descendente
                return dbContext.Usuarios.OrderByDescending(u => u.FechaCreacion).Take(10).ToList();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al obtener los últimos usuarios: " + ex.Message);
                return new List<Usuario>(); // Retorna una lista vacía en caso de error
            }
        }

        // Método para actualizar los datos de un usuario existente
        public void ActualizarUsuario(Usuario usuarioActualizado)
        {
            try
            {
                // Busca el usuario en la base de datos por su ID
                Usuario usuarioExistente = dbContext.Usuarios.Find(usuarioActualizado.Id);

                if (usuarioExistente != null)
                {
                    // Actualiza los datos del usuario existente
                    usuarioExistente.Nombre = usuarioActualizado.Nombre;
                    usuarioExistente.Apellido = usuarioActualizado.Apellido;
                    usuarioExistente.Documento = usuarioActualizado.Documento;
                    usuarioExistente.CorreoElectronico = usuarioActualizado.CorreoElectronico;

                    dbContext.SaveChanges(); // Guarda los cambios en la base de datos
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el usuario: " + ex.Message);
            }
        }
    }
}
