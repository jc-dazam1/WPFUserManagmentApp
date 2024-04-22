using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using UserManagmentApp.Models;
using UserManagmentApp.Utilities;

namespace UserManagmentApp.Views.Usuarios
{
    /// <summary>
    /// Lógica de interacción para EditarUsuarioView.xaml
    /// </summary>
    public partial class EditarUsuarioView : UserControl
    {
        private Usuario usuario;
        public ICommand GuardarUsuarioCommand { get; private set; }
        public EditarUsuarioView(Usuario usuarioSeleccionado)
        {
            InitializeComponent();

            // Inicializar el comando de editar usuario
            GuardarUsuarioCommand = new RelayCommand(ActualizarUsuario);

            // Guarda el usuario seleccionado para editar
            usuario = usuarioSeleccionado;

            // Muestra los datos del usuario en los TextBoxes
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtDocumento.Text = usuario.Documento;
            txtCorreo.Text = usuario.CorreoElectronico;
        }

        private void ActualizarUsuario(object parameter)
        {
            // Actualiza los datos del usuario con los valores de los TextBoxes
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Documento = txtDocumento.Text;
            usuario.CorreoElectronico = txtCorreo.Text;

            try
            {
                // Guarda los cambios en la BD
                using (var dbContext = new AppDbContext())
                {
                    // Busca el usuario por su ID
                    var usuarioEnBD = dbContext.Usuarios.Find(usuario.Id);
                    if (usuarioEnBD != null)
                    {
                        // Actualiza los datos del usuario 
                        usuarioEnBD.Nombre = usuario.Nombre;
                        usuarioEnBD.Apellido = usuario.Apellido;
                        usuarioEnBD.Documento = usuario.Documento;
                        usuarioEnBD.CorreoElectronico = usuario.CorreoElectronico;

                        dbContext.SaveChanges();
                        MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;

                        ListaUsuariosView listaUsuariosView = new ListaUsuariosView();
                        mainWindow.ContenidoPrincipal.Content = listaUsuariosView;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no fue encontrado en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario en la base de datos: " + ex.Message);
            }
        }


        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            // Obtiene la ventana que contiene este UserControl
            Window parentWindow = Window.GetWindow(this);

            // Cierra la ventana padre
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
    }
}
