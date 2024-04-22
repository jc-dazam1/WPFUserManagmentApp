using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using UserManagmentApp.Controllers;
using UserManagmentApp.Models;

namespace UserManagmentApp.Views.Usuarios
{
    public class ListaAreasViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Area _areaSeleccionada;
        public Area AreaSeleccionada
        {
            get { return _areaSeleccionada; }
            set
            {
                if (_areaSeleccionada != value)
                {
                    _areaSeleccionada = value;
                    OnPropertyChanged(nameof(AreaSeleccionada));
                    LoadUsuariosAsignados(); // Cargar los usuarios asignados cuando se cambie el área seleccionada
                }
            }
        }

        private ObservableCollection<Usuario> _usuariosAsignados;
        public ObservableCollection<Usuario> UsuariosAsignados
        {
            get { return _usuariosAsignados; }
            set
            {
                if (_usuariosAsignados != value)
                {
                    _usuariosAsignados = value;
                    OnPropertyChanged(nameof(UsuariosAsignados));
                }
            }
        }

        public ListaAreasViewModel()
        {
            Areas = new ObservableCollection<Area>();
            UsuariosAsignados = new ObservableCollection<Usuario>();
            var areaController = new AreaController();
            var areasObtenidas = areaController.ObtenerAreas();

            foreach (var area in areasObtenidas)
            {
                Areas.Add(area);
            }
        }

        // Método para cargar los usuarios asignados a la área seleccionada
        private void LoadUsuariosAsignados()
        {
            if (AreaSeleccionada != null)
            {
                var usuarioController = new UsuarioController();
                var usuariosAsignados = usuarioController.ObtenerUsuariosPorArea(AreaSeleccionada.Id);
                UsuariosAsignados.Clear();
                foreach (var usuario in usuariosAsignados)
                {
                    UsuariosAsignados.Add(usuario);
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Area> Areas { get; set; }

        public void SeleccionarArea(Area area)
        {
            AreaSeleccionada = area;
        }
    }
}

