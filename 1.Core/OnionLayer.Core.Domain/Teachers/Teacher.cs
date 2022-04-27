﻿using OnionSample.Core.Domain.BaseEntities;
using OnionSample.Core.Domain.Courses;

namespace OnionSample.Core.Domain.Teachers;

public class Teacher: BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<CourseTeacher> CourseTeachers { get; set; }

}
