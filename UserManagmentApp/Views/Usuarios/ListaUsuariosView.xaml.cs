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
using UserManagmentApp.ViewModels.Usuarios;

namespace UserManagmentApp.Views.Usuarios
{
    /// <summary>
    /// Lógica de interacción para ListaUsuariosView.xaml
    /// </summary>
    public partial class ListaUsuariosView : UserControl
    {
        private ListaUsuariosViewModel listaUsuariosViewModel;
        public ListaUsuariosView()
        {
            InitializeComponent();
            listaUsuariosViewModel = new ListaUsuariosViewModel();
            DataContext = new ListaUsuariosViewModel();
        }

    }
}
