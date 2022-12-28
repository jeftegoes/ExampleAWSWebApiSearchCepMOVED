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
        var environmentVariable = Environment.GetEnvironmentVariable("dynamo_db");

        Console.WriteLine(environmentVariable);

        return Ok(await _addressService.GetAddress(zipCode));
    }
}