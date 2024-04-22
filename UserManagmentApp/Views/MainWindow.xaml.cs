using Microsoft.EntityFrameworkCore;
using System.Windows;
using UserManagmentApp.Models;
using UserManagmentApp.Views.Usuarios;

namespace UserManagmentApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDbContext dbContext; // Contexto de la base de datos

        public MainWindow()
        {
            InitializeComponent();

            // Crea una instancia de AppDbContext utilizando las opciones de configuración
            dbContext = new AppDbContext();

            // Muestra la vista al iniciar la aplicación
            MostrarListaUsuarios(null, null);
        }


        private void MostrarCrearUsuario(object sender, RoutedEventArgs e)
        {
            // Muestra la vista de creación de usuario en el ContentControl
            ContenidoPrincipal.Content = new CrearUsuarioView();
        }

        private void MostrarListaUsuarios(object sender, RoutedEventArgs e)
        {
            // Muestra la vista de lista de usuarios en el ContentControl
            ContenidoPrincipal.Content = new ListaUsuariosView();
        }
    }
}