using HotelProject.Model;
using HotelProject.Services.HotelService;
using HotelProject.Services.CustomerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomerDetails()
        {

            return await _customerService.GetAllCustomerDetails();
        }


        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _customerService.GetCustomer(id);
            if (customer == null)
            {
                return NotFound("customer_id Not Available");
            }
            return Ok(customer);
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, Customer customer)
        {
            var UpCustomer = await _customerService.UpdateCustomer(id, customer);
            if (UpCustomer == null)
            {
                return NotFound("customer_id Not Available");
            }
            return Ok(UpCustomer);

        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer(Customer customer)
        {
            var newCustomer = await _customerService.AddCustomer(customer);


            return Ok(newCustomer);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var deleteCustomer = await _customerService.DeleteCustomer(id);
            if (deleteCustomer == null)
            {
                return NotFound("hotel_id Not Available");
            }

            return Ok(deleteCustomer);
        }


    }
}
