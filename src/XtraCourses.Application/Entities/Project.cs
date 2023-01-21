using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtraCourses.Application.ValueObject;

namespace XtraCourses.Application.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid CourseId { get; set; }
        public string ProjectName { get; set; }
        public ProjectDetails ProjectDetails { get; set; }
    }
}
