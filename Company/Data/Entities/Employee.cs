using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Data.Entities
{
    public class Employee
    {
        [Key]
        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("First_Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        [Column("Last_Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]

        public string Email { get; set; }
        [MaxLength(30)]
        [Column("Phone_Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Column("Hire_Date")]
        public DateTime HireDate { get; set; }
        [Required]
        [Column("Job_Id")]
        public int JobId { get; set; }
        public Job Job { get; set; }
        public decimal selary { get; set; }
        [Column("Department_Id")]
        public  int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
