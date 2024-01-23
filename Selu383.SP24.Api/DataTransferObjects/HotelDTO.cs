namespace Selu383.SP24.Api.DataTransferObjects
{
    public class HotelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class GetHotelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class CreateHotelDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class UpdateHotelDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

}
