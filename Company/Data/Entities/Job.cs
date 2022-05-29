using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Data.Entities
{
    public class Job
    {
        [Key]
        [Column("Job_Id")]
        public int JobId { get; set; }
        [Required]
        [MaxLength(35)]
        [Column("Job_Title")]
        public string JobTitle { get; set; }
        public decimal min_salary { get; set; }
        public decimal max_salary { get; set; }
    }
}
