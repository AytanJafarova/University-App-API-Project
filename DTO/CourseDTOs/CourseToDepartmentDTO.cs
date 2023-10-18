using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CourseDTOs
{
    public record CourseToDepartmentDTO
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? Credit { get; set; } 
        public int? Duration { get; set; }
    }
}
