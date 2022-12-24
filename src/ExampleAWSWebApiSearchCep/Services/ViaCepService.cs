using ExampleAWSWebApiSearchCep.Dtos;
using ExampleAWSWebApiSearchCep.Interfaces;
using Newtonsoft.Json;

namespace ExampleAWSWebApiSearchCep.Services
{
    public class ViaCepService : IAddressService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ViaCepService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

        }

        public async Task<EnderecoDto> GetAddress(string zipCode)
        {
            Console.WriteLine("REQUEST - ZipCode: {0}", zipCode);

            using (var client = _httpClientFactory.CreateClient())
            {
                client.BaseAddress = new Uri("https://viacep.com.br/ws/");

                const string format = "json";

                var url = $"{zipCode}/{format}/";

                var enderecoDto = JsonConvert.DeserializeObject<EnderecoDto>(await client.GetStringAsync(url));

                Console.WriteLine("RESPONSE {0}", JsonConvert.SerializeObject(enderecoDto));

                return enderecoDto;
            }
        }
    }
}