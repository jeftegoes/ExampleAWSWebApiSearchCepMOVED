using ExampleAWSWebApiSearchCep.Dtos;
using ExampleAWSWebApiSearchCep.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExampleAWSWebApiSearchCep.Controllers;

[Route("api/[controller]")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    // GET api/values
    [HttpGet("{zipCode}")]
    public async Task<IActionResult> Get(string zipCode)
    {
        try
        {
            return Ok(await _addressService.GetAddress(zipCode));
        }
        catch (Exception ex)
        {
            Console.WriteLine(JsonConvert.SerializeObject(ex));

            return Ok();
        }
    }
}