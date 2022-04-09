using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiddenVilla_Server.Data
{
    public class HotelRoom
    {


        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name Of Room")]
        public string Name { get; set; }
        [Required]
        [Range(1, 10)]
        public int Occupancy { get; set; }
        [Required]
        [Range(1,3000)]
        public double RegularRate { get; set; }
        [Required]
        [MaxLength(500)]
        public string Details { get; set; }
        public string SqFt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ICollection<HotelRoomImage> HotelRoomImages { get; set; }
        [NotMapped] public List<string> UploadedImages { get; set; } = new();

    }
}
