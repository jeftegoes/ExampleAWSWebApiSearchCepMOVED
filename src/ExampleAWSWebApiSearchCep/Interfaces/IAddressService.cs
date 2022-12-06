using ExampleAWSWebApiSearchCep.Dtos;

namespace ExampleAWSWebApiSearchCep.Interfaces
{
    public interface IAddressService
    {
        public Task<EnderecoDto> GetAddress(string zipCode);
    }
}