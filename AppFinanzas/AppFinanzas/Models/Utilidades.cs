using AppFinanzas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppFinanzas.Models
{
    public class Utilidades
    {
        private static List<Operacion> Operaciones => (List<Operacion>)DependencyService.Get<IDataStore<Operacion>>();

        public static List<Periodo> Periodos()
        {
            List<Periodo> periodos = new List<Periodo>();
            DateTime fechaMin = Operaciones.Select(x => x.Fecha).Min();
            DateTime fechaMax = Operaciones.Select(x => x.Fecha).Max();
            int cantidad = ((fechaMax.Year - fechaMin.Year) * 12) + fechaMax.Month - fechaMin.Month;
            for (int i = 0; i < cantidad; i++)
            {
                periodos.Add(new Periodo(fechaMin.AddMonths(i)));
            }

            return periodos;
        }
    }
}
