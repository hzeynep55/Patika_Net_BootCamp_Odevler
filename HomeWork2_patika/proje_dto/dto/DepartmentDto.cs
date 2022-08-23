using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_dto.dto
{
    public class DepartmentDto
    {
        [Required]
        [MaxLength(35)]
        [Display(Name = "DepartmentId")]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "DeptName")]
        public string DeptName { get; set; }

        [Required]
        [MaxLength(35)]
        [Display(Name = "CountryId")]
        public int CountryId { get; set; }
    }
}
