using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Services.CustomerFunctionService
{
    public interface ICustomerFunctionService
    {
        Task<object> Filter(string location);
    }
}
