using Newtonsoft.Json;
using UDS.Domain.Dto.Output;
using UDS.Domain.Interfaces.Repositories;

namespace UDS.Infra.Data.Repositories
{
    public class PeopleRepository : IPeopleRepository 
    {
        private readonly HttpClient _httpClient;
        private string urlBase = "https://swapi.dev/api/people";
        public PeopleRepository(HttpClient httpClient) 
        {
            _httpClient= httpClient;
        }

        public async Task<PeoplesOutputDto> List()
        {
            var response = await _httpClient.GetAsync($"{urlBase}/?page1");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<PeoplesOutputDto>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }
    }
}
