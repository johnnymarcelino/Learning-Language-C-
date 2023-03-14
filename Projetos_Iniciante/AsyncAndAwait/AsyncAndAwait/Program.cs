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
    }
}

