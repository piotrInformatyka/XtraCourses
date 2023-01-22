using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtraCourses.Application.Entities;

namespace XtraCourses.Application.DTO
{
    public static class Extensions
    {
        public static CourseDto AsDto(this Course entity)
            => new()
            {
                CourseId = entity.CourseId,
                CourseName = entity.CourseName
            };
    }
}
