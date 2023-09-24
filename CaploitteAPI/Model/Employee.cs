using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaploitteAPI.Model
{
    [Table("EmployeeDetail")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        
        [StringLength(250)]
        public string? FullName { get; set; }
       
        [StringLength(250)]
        public string? EmailAddress { get; set; }
        //public double Salary { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsActive{ get; set; }
    }
}
