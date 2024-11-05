using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Hotel.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public int GuestId { get; set; }
        [Required]
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        [JsonIgnore]
        public virtual Guest Guest { get; set; }
        [JsonIgnore]
        public virtual Room Room { get; set; }
    }
}
