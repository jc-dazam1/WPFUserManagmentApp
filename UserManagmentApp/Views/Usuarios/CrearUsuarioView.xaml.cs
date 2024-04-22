using Microsoft.EntityFrameworkCore;
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
using UserManagmentApp.Controllers;
using UserManagmentApp.Models;

namespace UserManagmentApp.Views.Usuarios
{
    /// <summary>
    /// Lógica de interacción para CrearUsuarioView.xaml
    /// </summary>
    public partial class CrearUsuarioView : UserControl
    {
        private UsuarioController UsuarioController;
        public CrearUsuarioView()
        {
            InitializeComponent();

            UsuarioController = new UsuarioController();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            // Captura los datos ingresados por el usuario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string documento = txtDocumento.Text;
            string correo = txtCorreo.Text;

            // Crea un nuevo objeto Usuario con los datos capturados
            Usuario nuevoUsuario = new Usuario(nombre, apellido, documento, correo);
            UsuarioController.GuardarUsuario(nuevoUsuario);


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
