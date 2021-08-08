using AppFinanzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace AppFinanzas.Services
{
    public class DataStore : IDataStore<Operacion>
    {
        private readonly List<Operacion> operaciones;

        public DataStore()
        {
            operaciones = new List<Operacion>()
            {
                new Operacion()
            };
        }

        public async Task<bool> AddItemAsync(Operacion operacion)
        {
            operaciones.Add(operacion);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var auxOperacion = operaciones.Where((Operacion arg) => arg.Id == id).FirstOrDefault();
            operaciones.Remove(auxOperacion);

            return await Task.FromResult(true);
        }

        public async Task<Operacion> GetItemAsync(string id)
        {
            return await Task.FromResult(operaciones.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Operacion>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(operaciones);
        }

        public async Task<bool> UpdateItemAsync(Operacion operacion)
        {
            var auxOperacion = operaciones.Where((Operacion arg) => arg.Id == operacion.Id).FirstOrDefault();
            operaciones.Remove(auxOperacion);
            operaciones.Add(operacion);

            return await Task.FromResult(true);
        }
    }
}
