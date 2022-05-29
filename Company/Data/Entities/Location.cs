using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Data.Entities
{
    public class Location
    {
        [Key]
        [Column("Location_Id")]
        public int LocationId { get; set; }
        [MaxLength(40)]
        [Column("Street_Address")]
        public string StreetAddress { get; set; }
        [MaxLength(12)]
        [Column("Postal_Code")]
        public int PostalCode { get; set; }
        [Required]
        [MaxLength(30)]
        public string City { get; set; }
        [Required]
        [MaxLength(25)]
        [Column("State_Province")]
        public string StateProvince { get; set; }
        [Required]
        [MaxLength(2)]
        [Column("Country_Id")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        
    }
}
