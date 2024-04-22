using System.Windows.Controls;
using UserManagmentApp.Models;
using UserManagmentApp.Views.Usuarios;

namespace UserManagmentApp.Views.Areas
{
    /// <summary>
    /// Lógica de interacción para ListaAreasView.xaml
    /// </summary>
    public partial class ListaAreasView : UserControl
    {
        public ListaAreasView()
        {
            InitializeComponent();
            DataContext = new ListaAreasViewModel();
        }

        private void ListaAreas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtiene el ViewModel asociado a esta vista
            var viewModel = (ListaAreasViewModel)DataContext;

            // Obtiene el área seleccionada en el ListBox
            var areaSeleccionada = (Area)ListBoxAreas.SelectedItem;

            // Llama al método en el ViewModel para manejar la selección del área
            viewModel.SeleccionarArea(areaSeleccionada);
        }
    }
}
