using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Data.Entities
{
    public class Department
    {
        [Key]
        [Column("Department_Id")]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(30)]
        [Column("Department_Name")]
        public string DepartmentName { get; set; }
        public int location_id { get; set; }
        public Location location { get; set; }
    }
}
