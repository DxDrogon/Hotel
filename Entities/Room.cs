using System.ComponentModel.DataAnnotations;

namespace Hotel.Entities
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        public string RoomNumber { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public decimal PricePerNight { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
