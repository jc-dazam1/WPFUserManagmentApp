using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using UserManagmentApp.Controllers;
using UserManagmentApp.Models;

namespace UserManagmentApp.Views.Areas
{
    public partial class AsignarUsuarioAreaView : UserControl
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Area> Areas { get; set; }

        public AsignarUsuarioAreaView()
        {
            InitializeComponent();
            
            //Asignar valores ListComboBox
            Usuarios = ObtenerUsuarios();
            Areas = ObtenerAreas();
            DataContext = this; // Establecer el DataContext para el enlace de datos
        }

        // Método para manejar el evento de clic del botón "Asignar"
        private void AssignButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el usuario seleccionado
            Usuario selectedUser = (Usuario)userComboBox.SelectedItem;

            // Obtener el área seleccionada
            Area selectedArea = (Area)areaComboBox.SelectedItem;

            // Realizar la asignación de usuario a área (puedes implementar la lógica de acuerdo a tus necesidades)
            if (selectedUser != null && selectedArea != null)
            {
                selectedUser.AreaId = selectedArea.Id;

                // Actualizar la interfaz de usuario para mostrar un mensaje de confirmación
                confirmationTextBlock.Text = "Asignación exitosa: " + selectedUser.Nombre + " asignado a " + selectedArea.Nombre;
            }
            else
            {
                confirmationTextBlock.Text = "Error: Por favor selecciona un usuario y un área.";
            }
        }

        // Método para obtener una lista de usuarios (puedes implementarlo según tus necesidades)
        private List<Usuario> ObtenerUsuarios()
        {
            UsuarioController usuarioController = new UsuarioController();
            return usuarioController.ObtenerTodosUsuarios();
        }

        // Método para obtener una lista de áreas (puedes implementarlo según tus necesidades)
        private List<Area> ObtenerAreas()
        {
            AreaController areaController = new AreaController();  
            
            return areaController.ObtenerAreas();
        }
    }
}
