using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanzas.Models
{
    public class Periodo
    {
        public int Indice { get; set; }
        public Mes Nombre { get; set; }
        public DateTime PrimerDia { get; set; }
        public DateTime UltimoDia { get; set; }

        public Periodo(DateTime fecha)
        {
            Indice = fecha.Month;
            Nombre = (Mes)Indice;
            PrimerDia = new DateTime(fecha.Year, Indice, 1);
            UltimoDia = PrimerDia.AddMonths(1).AddDays(-1);
        }
    }
}
