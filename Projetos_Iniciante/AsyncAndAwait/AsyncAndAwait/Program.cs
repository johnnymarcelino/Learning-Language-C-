using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
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

            public IEnumerable<Company> GetAllCompanies() =>
                    _repoContext.Companies
                    .OrderBy(c => c.Name)
                    .ToList();

            public async Task<IEnumerable<Company>> GetAllCompanies()
            {
                var companies = await _repoContext.Companies
                    .OrderBy(c => c.Name)
                    .ToListAsync();

                return companies;
            }

            public interface ICompanyRepository
        {
            Task<IEnumerable<Company>> GetAllCompanies();
            Company GetCompany(Guid companyId);
            void CreateCompany(Company company);
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _repository.GetAllCompanies();

            var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);

            _logger.LogInfo("All companies fetched from the database");

            return Ok(companiesDto);
        }

        private async Task GetCompaniesWithHttpClientFactory()
        {
            var httpClient = _httpClientFactory.CreateClient();
            using (var response = await httpClient.GetAsync("https://localhost:5001/api/companies", HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();
                var companies = await JsonSerializer.DeserializeAsync<List<CompanyDto>>(stream, _options);
            }
        }

        // Suponha que você tenha uma função longa que leva muito tempo para ser executada e deseja executá-la em uma thread separada.
        // forma assícrona:
    }

    class ProgramTask
    {
        static void Main()
        {
            Task.Run(() => LongOperation());
            Console.WriteLine("A operação longa foi iniciada em segundo plano.");
            Console.ReadLine();
        }

        static void LongOperation()
        {
            // Simula uma operação longa
            Task.Delay(5000).Wait();
            Console.WriteLine("A operação longa foi concluída.");
        }

        // Nesse exemplo, a função LongOperation() é executada em segundo plano em uma nova Task,
        // permitindo que a thread principal continue executando outras tarefas enquanto a operação está em andamento.
        // O método Task.Delay() é usado para simular uma operação longa que leva 5 segundos para ser concluída.
        // Depois que a tarefa é concluída, a mensagem "A operação longa foi concluída." é impressa no console.

        // Observe que o método Task.Run() inicia a tarefa de forma assíncrona e retorna imediatamente,
        // permitindo que o restante do código seja executado.
        // Isso é útil para operações que podem levar algum tempo para serem concluídas
        // e que não precisam ser concluídas imediatamente.

    }

    class ProgramTaskAwait
    {
        static async Task Main()
        {
            Console.WriteLine("Iniciando a chamada de rede...");
            string resultado = await Task.Run(() => ObterDadosDoServidor());
            Console.WriteLine($"Os dados obtidos do servidor são: {resultado}");
            Console.ReadLine();
        }

        static string ObterDadosDoServidor()
        {
            using var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }

        /*
        Nesse exemplo, o método ObterDadosDoServidor() é executado em uma nova Task utilizando o método Task.Run(). 
        O método faz uma chamada de rede para um servidor externo e retorna os dados obtidos como uma string. 
        A palavra-chave async é usada no método Main() para indicar que ele é assíncrono e pode esperar pela conclusão da Task
        com a palavra-chave await.

        O método Main() inicia a tarefa utilizando await Task.Run() 
        e espera pela conclusão da tarefa para receber os dados obtidos do servidor. 
        Isso permite que a thread principal continue a executar outras tarefas 
        enquanto a chamada de rede está sendo feita em segundo plano.
        Observe que o uso do async/await torna o código mais fácil de ler e escrever, 
        pois permite que as tarefas assíncronas sejam escritas como se fossem síncronas, sem bloquear a thread principal. 
        */
    }
}

