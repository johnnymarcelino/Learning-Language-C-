using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
              // Tipos de retorno dos métodos assíncronos
              // Na programação assíncrona, temos três tipos de retorno:

              // Task<TResult>, para um método assíncrono que retorna um valor
              // Tarefa, para usá-la para um método assíncrono que não retorna um valor
              // void, que podemos usar para um manipulador de eventos

            async Task<IEnumerable<Company>> GetCompanies()
            {
                _logger.LogInfo("Inside the GetCompanies method.");

                var companies = await _repoContext.Companies.ToListAsync();

                return companies;
            }
        }
    }
}
