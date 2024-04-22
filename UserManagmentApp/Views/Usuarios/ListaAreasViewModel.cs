using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    OnPropertyChanged("AreaSeleccionada");
                }
            }
        }

        public ObservableCollection<Area> Areas { get; set; }

        public ListaAreasViewModel()
        {

            Areas = new ObservableCollection<Area>();
            var areaController = new AreaController();
            var areasObtenidas = areaController.ObtenerAreas();

            foreach (var area in areasObtenidas)
            {
                Areas.Add(area);
            }

        }

        public void SeleccionarArea(Area area)
        {
            AreaSeleccionada = area;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
