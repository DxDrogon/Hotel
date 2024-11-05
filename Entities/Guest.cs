using System.ComponentModel.DataAnnotations;

namespace Hotel.Entities
{
    public class Guest
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
