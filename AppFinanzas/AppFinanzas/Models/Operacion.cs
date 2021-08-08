using System;

namespace AppFinanzas.Models
{
    public class Operacion
    {
        public string Id { get; }
        public Tipo Tipo { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public readonly DateTime Fecha = DateTime.Today;

        private decimal monto;
        public decimal Monto
        {
            get => monto;
            set => monto = decimal.Round(value, 2);
        }

        public Operacion(Tipo tipo, string descripcion, Categoria categoria)
        {
            Id = Guid.NewGuid().ToString();
            Tipo = tipo;
            Descripcion = descripcion;
            Categoria = categoria;
            Monto = 0;
        }

        public Operacion() : this(Tipo.Egreso, string.Empty, Categoria.Otros) { }

    }
}
