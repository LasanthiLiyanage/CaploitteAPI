using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaploitteAPI.Model
{
    [Table("EmployeeSalaryDetails")]
    public class EmployeeSalaryDetails
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpSalaryId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }
        public DateTime SalaryDate { get; set; }
        public double SalaryAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public int? CreatedBy { get; set; }
    }
}
