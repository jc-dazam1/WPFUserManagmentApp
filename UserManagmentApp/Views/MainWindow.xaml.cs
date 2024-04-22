using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserManagmentApp.Views.Usuarios;

namespace UserManagmentApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Muestra la vista por defecto al iniciar la aplicación
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