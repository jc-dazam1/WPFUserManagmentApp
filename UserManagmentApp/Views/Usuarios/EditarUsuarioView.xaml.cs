using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserManagmentApp.Models;

namespace UserManagmentApp.Views.Usuarios
{
    /// <summary>
    /// Lógica de interacción para EditarUsuarioView.xaml
    /// </summary>
    public partial class EditarUsuarioView : UserControl
    {
        private Usuario usuario;
        public EditarUsuarioView(Usuario usuarioSeleccionado)
        {
            InitializeComponent();

            // Guarda el usuario seleccionado para editar
            usuario = usuarioSeleccionado;

            // Muestra los datos del usuario en los TextBoxes
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtDocumento.Text = usuario.Documento;
            txtCorreo.Text = usuario.CorreoElectronico;
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            // Actualiza los datos del usuario con los valores de los TextBoxes
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Documento = txtDocumento.Text;
            usuario.CorreoElectronico = txtCorreo.Text;

  
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
