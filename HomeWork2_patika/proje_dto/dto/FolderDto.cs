using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_dto.dto
{
    public class FolderDto
    {
        [Required]
        [MaxLength(35)]
        [Display(Name = "FolderId")]
        public int FolderId { get; set; }

        [Required]
        [MaxLength(35)]
        [Display(Name = "EmpId")]
        public int EmpId { get; set; }

        
        [MaxLength(25)]
        [Display(Name = "AccessType")]
        public string AccessType { get; set; }
    }
}
