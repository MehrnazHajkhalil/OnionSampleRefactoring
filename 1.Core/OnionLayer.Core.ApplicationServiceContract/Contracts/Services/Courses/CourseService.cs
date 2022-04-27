using OnionSample.Core.ApplicationServiceContract.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Core.ApplicationServiceContract.Contracts.Services
{
    public interface ICourseService
    {
        void AddCourse(CourseDto course);
        void RemoveCourse(CourseDto course,int id);
        void UpdateCourse(CourseDto newmodel, CourseDto oldModel);
        CourseDto GetCourse(int id);
        List<CourseDto> GetAllCourses();

    }

  
}
