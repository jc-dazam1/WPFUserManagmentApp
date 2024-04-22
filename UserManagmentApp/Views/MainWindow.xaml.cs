using Microsoft.EntityFrameworkCore;
using System.Windows;
using UserManagmentApp.Models;
using UserManagmentApp.Utilities;
using UserManagmentApp.ViewModels.Usuarios;
using UserManagmentApp.Views.Areas;
using UserManagmentApp.Views.Usuarios;

namespace UserManagmentApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDbContext dbContext; // Contexto de la base de datos

        private ListaUsuariosViewModel listaUsuariosViewModel;


        public MainWindow()
        {
            InitializeComponent();
            listaUsuariosViewModel = new ListaUsuariosViewModel();
            dbContext = new AppDbContext();
        }


        private void MostrarCrearUsuario(object sender, RoutedEventArgs e)
        {
            var crearUsuarioView = new CrearUsuarioView(listaUsuariosViewModel);
            crearUsuarioView.UsuarioGuardado += CrearUsuarioView_UsuarioGuardado;
            ContenidoPrincipal.Content = crearUsuarioView;
        }

        private void CrearUsuarioView_UsuarioGuardado(object sender, EventArgs e)
        {
            listaUsuariosViewModel.CargarUsuarios(); // Cargar la lista de usuarios después de guardar uno nuevo
        }

        private void MostrarListaUsuarios(object sender, RoutedEventArgs e)
        {
            // Muestra la vista de lista de usuarios en el ContentControl
            ContenidoPrincipal.Content = new ListaUsuariosView();
        }

        private void MostrarListaAreas(object sender, RoutedEventArgs e)
        {
            ContenidoPrincipal.Content = new ListaAreasView();
        }

        private void MostrarAsignarAreaUsuario(object sender, RoutedEventArgs e)
        {
            ContenidoPrincipal.Content = new AsignarUsuarioAreaView();
        }
    }
}