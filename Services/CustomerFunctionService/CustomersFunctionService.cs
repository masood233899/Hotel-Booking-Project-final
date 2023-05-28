using HotelProject.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Services.CustomerFunctionService
{
    public class CustomerFunctionService: ICustomerFunctionService
    {
        public HotelDbContext _hotelDbContext;

        public CustomerFunctionService(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }
        public async Task<object> Filter(string location)
        {
            var reqHotel = await _hotelDbContext.Hotels.FirstOrDefaultAsync(x => x.HotelAddress == location);
            return reqHotel.HotelName;
        }

    }
}
