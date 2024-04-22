using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UserManagmentApp.Models;

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
    public List<Usuario> Usuarios { get; set; } // Colección de usuarios asociados a esta área

    public Area()
    {
        // Inicializar la colección de usuarios
        Usuarios = new List<Usuario>();
    }

    static Area()
    {
        AreasPredefinidas = new List<Area>
        {
            new Area { Id = -1, Nombre = "No Asignado" },
            new Area { Id = 1, Nombre = "Nómina" },
            new Area { Id = 2, Nombre = "Facturación" },
            new Area { Id = 3, Nombre = "Servicio al Cliente" }
        };
    }
}
