using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Data.Entities
{
    public class Region
    {
        [Key]
        [Column("Region_Id")]
        public int Regionid { get; set; }
        [MaxLength(25)]
        [Column("Region_Name")]
        public string RegionName { get; set; }
        
    }
}
