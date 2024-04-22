using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using UserManagmentApp.Models;
using UserManagmentApp.Utilities;

namespace UserManagmentApp.ViewModels.Usuarios
{
    public class ListaUsuariosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Usuario> _usuarios;
        public ObservableCollection<Usuario> Usuarios
        {
            get { return _usuarios; }
            set
            {
                _usuarios = value;
                OnPropertyChanged(nameof(Usuarios));
            }
        }

        private Usuario _usuarioSeleccionado;
        public Usuario UsuarioSeleccionado
        {
            get { return _usuarioSeleccionado; }
            set
            {
                _usuarioSeleccionado = value;
                OnPropertyChanged(nameof(UsuarioSeleccionado));
            }
        }

        public ICommand EditarUsuarioCommand { get; private set; }

        public ListaUsuariosViewModel()
        {
            // Lógica para cargar los usuarios
            Usuarios = new ObservableCollection<Usuario>();

            // Inicializar el comando de editar usuario
            EditarUsuarioCommand = new RelayCommand(EditarUsuario);
        }

        private void EditarUsuario(object parameter)
        {
            // Lógica para editar el usuario seleccionado
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
