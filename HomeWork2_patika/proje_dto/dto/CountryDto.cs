using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_dto.dto
{
    public class  CountryDto
    {
        [Required]
        [MaxLength(35)]
        [Display(Name = "CountryId")]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(400)]
        [Display(Name = "CountryName")]
        public string CountryName { get; set; }

        
        [MaxLength(20)]
        [Display(Name = "Continent")]
        public string Continent { get; set; }


        [MaxLength(4)]
        [Display(Name = "Currency")]
        public string Currency { get; set; }
    }
}
