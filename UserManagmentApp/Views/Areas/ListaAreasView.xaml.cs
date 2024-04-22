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
            //viewModel.SeleccionarArea((Area)ListaAreas.SelectedItem);
        }
    }
}
