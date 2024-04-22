using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentApp.Models;
using UserManagmentApp.Utilities;

namespace UserManagmentApp.Controllers
{
    public class AreaController
    {
        private readonly AppDbContext dbContext;
        public AreaController() {
            dbContext = new AppDbContext();

        }
        public List<Area> ObtenerAreas()
        {
            try
            {
                return dbContext.Areas.ToList();
            }
            catch(Exception ex) 
            {
                // Manejo de errores
                Console.WriteLine("Error al obtener las areas: " + ex.Message);
                return new List<Area>(); // Retorna una lista vacía en caso de error
            }
            
        }
    }
}
