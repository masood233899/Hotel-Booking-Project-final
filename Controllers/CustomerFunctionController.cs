using HotelProject.Model;
using HotelProject.Services.CustomerFunctionService;
using HotelProject.Services.CustomerService;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerFunctionController : ControllerBase
    {
        private readonly ICustomerFunctionService _customerFunctionService;

        public CustomerFunctionController(ICustomerFunctionService customerFunctionService)
        {
            _customerFunctionService = customerFunctionService;
        }
        [HttpGet("{location}")]
        public async Task<ActionResult<object>> Filter(string location)
        {
            var customer = await _customerFunctionService.Filter(location);
            if (customer == null)
            {
                return NotFound("customer_id Not Available");
            }
            return Ok(customer);
        }
    }
}
