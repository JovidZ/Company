using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Data.Entities
{
    public class Dependent
    {
        [Key]
        [Column("Department_Id")]
        public int DependentId { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("First_Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("Last_Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Relationship { get; set; }
        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        

    }
}
