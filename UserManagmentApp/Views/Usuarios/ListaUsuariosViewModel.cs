using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using UserManagmentApp.Models;
using UserManagmentApp.Utilities;
using UserManagmentApp.Views.Usuarios;

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
            // Inicializar el comando de editar usuario
            EditarUsuarioCommand = new RelayCommand(EditarUsuario);

            // Cargar los usuarios al iniciar el ViewModel
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            // Acceder a la base de datos y obtener la lista de usuarios
            using (var dbContext = new AppDbContext())
            {
                // Obtener los últimos 10 usuarios
                var ultimosUsuarios = dbContext.Usuarios.OrderByDescending(u => u.FechaCreacion).Take(10).ToList();

                // Actualizar la propiedad Usuarios con los últimos usuarios obtenidos
                Usuarios = new ObservableCollection<Usuario>(ultimosUsuarios);
            }
        }

        private void EditarUsuario(object parameter)
        {
            // Verificar que se haya seleccionado un usuario
            if (parameter != null && parameter is Usuario usuarioSeleccionado)
            {
                // Asigna el usuario seleccionado a la propiedad UsuarioSeleccionado
                UsuarioSeleccionado = usuarioSeleccionado;

                // Cargar la información del usuario seleccionado en los campos de edición
                NombreEdicion = usuarioSeleccionado.Nombre;
                ApellidoEdicion = usuarioSeleccionado.Apellido;
                DocumentoEdicion = usuarioSeleccionado.Documento;
                CorreoEdicion = usuarioSeleccionado.CorreoElectronico;

                EditarUsuarioView editarUsuarioView = new EditarUsuarioView(UsuarioSeleccionado);
                editarUsuarioView.DataContext = editarUsuarioView;
                MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;

                mainWindow.ContenidoPrincipal.Content = editarUsuarioView;


            }
        }

        private void GuardarCambiosUsuario(object parameter)
        {
            // Verifica que se haya seleccionado un usuario
            if (UsuarioSeleccionado != null)
            {
                // Actualiza los campos del usuario seleccionado con los valores editados
                UsuarioSeleccionado.Nombre = NombreEdicion;
                UsuarioSeleccionado.Apellido = ApellidoEdicion;
                UsuarioSeleccionado.Documento = DocumentoEdicion;
                UsuarioSeleccionado.CorreoElectronico = CorreoEdicion;

                // Guarda los cambios en la base de datos
                using (var dbContext = new AppDbContext())
                {
                    dbContext.Usuarios.Update(UsuarioSeleccionado);
                    dbContext.SaveChanges();
                }

                // Vuelve a cargar la lista de usuarios para reflejar los cambios
                CargarUsuarios();
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string _nombreEdicion;
        public string NombreEdicion
        {
            get { return _nombreEdicion; }
            set
            {
                _nombreEdicion = value;
                OnPropertyChanged(nameof(NombreEdicion));
            }
        }

        private string _apellidoEdicion;
        public string ApellidoEdicion
        {
            get { return _apellidoEdicion; }
            set
            {
                _apellidoEdicion = value;
                OnPropertyChanged(nameof(ApellidoEdicion));
            }
        }

        private string _documentoEdicion;
        public string DocumentoEdicion
        {
            get { return _documentoEdicion; }
            set
            {
                _documentoEdicion = value;
                OnPropertyChanged(nameof(DocumentoEdicion));
            }
        }

        private string _correoEdicion;
        public string CorreoEdicion
        {
            get { return _correoEdicion; }
            set
            {
                _correoEdicion = value;
                OnPropertyChanged(nameof(CorreoEdicion));
            }
        }
    }
}
