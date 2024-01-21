using System.ComponentModel.DataAnnotations;

namespace Selu383.SP24.Api.DataTransferObjects
{
    public class HotelDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
    }

    public class CreateHotelDTO 
    {
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

    }

}
