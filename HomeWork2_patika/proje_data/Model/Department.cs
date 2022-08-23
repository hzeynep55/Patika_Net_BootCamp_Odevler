﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Model
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DeptName { get; set; }
        public int CountryId { get; set; }
    }
}
