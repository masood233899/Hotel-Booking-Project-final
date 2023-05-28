using HotelProject.Data;
using HotelProject.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        public HotelDbContext _hotelDbContext;

        public CustomerService(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }
        public async Task<List<Customer>> GetAllCustomerDetails()

        {
            var customers = await _hotelDbContext.Customers.ToListAsync();
            return customers;
        }
        public async Task<Customer> GetCustomer(int id)
        {
            var customer = await _hotelDbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }
            return customer;
        }
        public async Task<List<Customer>?> UpdateCustomer(int id, Customer customer)
        {
            var upcustomer = await _hotelDbContext.Customers.FindAsync(id);
            if (upcustomer == null)
            {
                return null;
            }
            upcustomer.customerId = customer.customerId;
            upcustomer.customerName = customer.customerName;
            upcustomer.customerPhone = customer.customerPhone;
            upcustomer.customerAddress = customer.customerAddress;
            
            await _hotelDbContext.SaveChangesAsync();
            return await _hotelDbContext.Customers.ToListAsync();
        }
        public async Task<List<Customer>> AddCustomer(Customer customer)
        {
            _hotelDbContext.Customers.Add(customer);
            await _hotelDbContext.SaveChangesAsync();
            return await _hotelDbContext.Customers.ToListAsync();
        }
        public async Task<List<Customer>?> DeleteCustomer(int id)
        {
            var customer = await _hotelDbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }
            _hotelDbContext.Customers.Remove(customer);
            await _hotelDbContext.SaveChangesAsync();
            return await _hotelDbContext.Customers.ToListAsync();
        }


    }
}
