﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DepartmentDTOs
{
    public record DepartmentToCourseDTO
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
