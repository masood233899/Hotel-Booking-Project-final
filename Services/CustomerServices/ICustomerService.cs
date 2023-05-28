using HotelProject.Model;

namespace HotelProject.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomerDetails();
        Task<Customer> GetCustomer(int id);
        Task<List<Customer>?> UpdateCustomer(int id, Customer customer);
        Task<List<Customer>> AddCustomer(Customer customer);
        Task<List<Customer>?> DeleteCustomer(int id);
    }
}
