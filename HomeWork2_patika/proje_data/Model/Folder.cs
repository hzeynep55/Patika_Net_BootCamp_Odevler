using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Model
{
    public class Folder
    {
        [Key]
        public int FolderId { get; set; }
        public int EmpId { get; set; }
        public string AccessType{get; set; }

    }
}
