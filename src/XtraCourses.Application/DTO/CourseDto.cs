using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtraCourses.Application.Entities;

namespace XtraCourses.Application.DTO
{
    public class CourseDto
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
