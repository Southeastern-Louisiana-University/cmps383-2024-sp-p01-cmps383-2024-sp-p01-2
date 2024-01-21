using Microsoft.AspNetCore.Mvc;
using Selu383.SP24.Api.DataTransferObjects;
using Selu383.SP24.Api.Entity;

namespace Selu383.SP24.Api.Controllers
{
    [ApiController]
    [Route("api/hotels")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;
        private readonly DataContext _context; // Inject DataContext

        public HotelController(ILogger<HotelController> logger, DataContext context)
        {
            _logger = logger;
            _context = context; // Initialize DataContext
        }

        [HttpGet]
        public ActionResult<List<HotelDTO>> GetHotels()
        {
            var hotels = _context.Hotel
                .Select(hotel => new HotelDTO
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Address = hotel.Address
                })
                .ToList();

            return hotels;
        }

        [HttpPost]
        public ActionResult<HotelDTO> AddHotel([FromBody] CreateHotelDTO hotelDTO)
        {
            try
            {
                if (hotelDTO == null)
                {
                    return BadRequest("Invalid hotel data.");
                }
                if (hotelDTO.Address == null)
                {
                    return BadRequest("Invalid hotel data.");
                }
                var newHotel = new Hotel
                {
                    Name = hotelDTO.Name,
                    Address = hotelDTO.Address
                    // Add other properties as needed
                };

                _context.Hotel.Add(newHotel);
                _context.SaveChanges();

                // You can return the added hotel or a confirmation message
                return CreatedAtAction(nameof(AddHotel), new { id = newHotel.Id }, newHotel);
            }
            catch (Exception ex)
            {
                // Log the exception
                // Return a meaningful error response
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<HotelDTO> GetHotelById(int id)
        {
            var hotel = _context.Hotel.Find(id);

            if (hotel == null)
            {
                return NotFound("Hotel not found.");
            }

            var hotelDTO = new HotelDTO
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Address = hotel.Address
                // Add other properties as needed
            };

            return Ok(hotelDTO);
        }
        [HttpPut("{id}")]
        public ActionResult<HotelDTO> UpdateHotel(int id, [FromBody] HotelDTO hotelDTO)
        {
            if (hotelDTO == null || id != hotelDTO.Id)
            {
                return BadRequest("Invalid hotel data or mismatched IDs.");
            }

            var existingHotel = _context.Hotel.Find(id);

            if (existingHotel == null)
            {
                return NotFound("Hotel not found.");
            }

            // Update the existing hotel properties
            existingHotel.Name = hotelDTO.Name;
            existingHotel.Address = hotelDTO.Address;
            // Update other properties as needed

            _context.SaveChanges();

            // You can return the updated hotel or a confirmation message
            return Ok(existingHotel);
        }


    }
}
