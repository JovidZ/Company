using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Data.Entities
{
    public class Country
    {
        [Key]
        [MaxLength(2)]
        [Column("Country_Id")]
        public int CountryId { get; set; }
        [MaxLength(40)]
        [Required]
        [Column("Country_Name")]
        public string CountryName { get; set; }
        [Required]
        [Column("Region_Id")]
        public int RegionId { get; set; }
        public Region Region { get; set; }
        
    }
}
