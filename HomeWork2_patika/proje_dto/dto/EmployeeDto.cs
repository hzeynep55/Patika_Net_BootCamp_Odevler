using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_dto.dto
{
    public class EmployeeDto
    {
        [Required]
        [MaxLength(20)]
        [Display(Name = "EmpId")]
        public int EmpId { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "EmpName")]
        public string EmpName { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "DeptId")]
        public int DeptId { get; set; }
    }
}
