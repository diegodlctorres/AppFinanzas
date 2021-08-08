using AppFinanzas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFinanzas.ViewModels
{
    public class OperacionesViewModel : BaseViewModel
    {
        //private List<Periodo> periodos;
        //public List<Periodo> Periodos
        //{
        //    get => periodos;
        //    private set
        //    {
        //        SetProperty(ref periodos, value);
        //        OnFechaSeleccionada(value);
        //    }
        //}

        //private Periodo periodoSeleccionado = new Periodo(DateTime.Today);
        //public Periodo PeriodoSeleccionado
        //{
        //    get => periodoSeleccionado;
        //    set => SetProperty(ref periodoSeleccionado, value);
        //}

        public ObservableCollection<Operacion> Operaciones { get; }

        public Command SeleccionarMesCommand { get; }
        public Command CargarOperacionesCommand{ get; }

        public OperacionesViewModel()
        {
            Title = "Operaciones";

            //periodos = new List<Periodo>();
            


            Operaciones = new ObservableCollection<Operacion>();
            CargarOperacionesCommand = new Command(async () => await ExecuteCargarOperacionesCommand());
        }

        //private async void OnFechaSeleccionada(List<Periodo> fecha)
        //{
        //    if (fecha == null) 
        //        return;
            
        //    throw new NotImplementedException();
        //}

        private async Task ExecuteCargarOperacionesCommand()
        {
            IsBusy = true;

            try
            {
                Operaciones.Clear();
                var operaciones = await OperacionDataStore.GetItemsAsync(true);                
                foreach (var operacion in operaciones)
                {
                    Operaciones.Add(operacion);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
