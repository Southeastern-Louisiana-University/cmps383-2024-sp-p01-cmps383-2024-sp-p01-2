using Microsoft.AspNetCore.Mvc;
using Selu383.SP24.Api.DataTransferObjects;
using Selu383.SP24.Api.Entity;

namespace Selu383.SP24.Api.Controllers
{
    [ApiController]
    [Route("Hotel")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;
        private readonly DataContext _context; // Inject DataContext

        public HotelController(ILogger<HotelController> logger, DataContext context)
        {
            _logger = logger;
            _context = context; // Initialize DataContext
        }

        [HttpGet("GetHotels")]
        public ActionResult<List<HotelDTO>> GetHotels()
        {
            var hotelDTO = _context.Hotels
                .Select(hotel => new HotelDTO
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Address = hotel.Address
                    // Add other properties as needed
                })
                .ToList();

            return hotelDTO;
        }

    }
}
