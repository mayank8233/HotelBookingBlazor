using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace HotelBookingBlazor.Data.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(25)]
        public string Name { get; set; }
        [Required, MaxLength(25)]
        public string Image { get; set; }
        [Required, Range(1, double.MaxValue)]
        public decimal Price { get; set; }
        [Required, MaxLength(200)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
        public bool IsAvailable { get; set; }

        public DateTime AddedOn { get; set; }

        public string  AddedBy { get; set; }

        public DateTime? LastUpdatedOn { get; set; }
        public string? LastUpdatedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        public virtual ApplicationUser AddedByUser { get; set; }
    }

    public class Amenity
    {
        public int id { get; set; }
        public string  Name { get; set; }

        public string Icon { get; set; }
    }
} 