using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Core.Domain.BaseEntities;
using OnionSample.Core.Domain.Tags;

namespace OnionSample.Core.Domain.Courses;

public class Course : BaseEntity
{
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndTime { get; set; }
    public int Price { get; set; }
    public string ImageUrl { get; set; }
    public List<Tag> Tags { get; set; }
    public List<CourseTeacher> CourseTeachers { get; set; }
    public List<CourseComment> CourseComments { get; set; }

}
