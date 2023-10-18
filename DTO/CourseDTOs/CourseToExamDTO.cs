using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CourseDTOs
{
    public record CourseToExamDTO
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? Credit { get; set; } 
    }
}
