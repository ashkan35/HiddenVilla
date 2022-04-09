namespace HiddenVilla_Server.Data
{
    public class HotelRoomImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int HotelRoomId { get; set; }
        public HotelRoom HotelRoom { get; set; }
    }
}
