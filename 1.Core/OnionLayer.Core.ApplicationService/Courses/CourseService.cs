using OnionSample.Core.ApplicationServiceContract.Contracts.Dtos;
using OnionSample.Core.ApplicationServiceContract.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Core.ApplicationService.Course
{
    public class CourseService : ICourseService
    {
        public void AddCourse(CourseDto course)
        {
            throw new NotImplementedException();
        }

        public List<CourseDto> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public CourseDto GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCourse(CourseDto course, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(CourseDto newmodel, CourseDto oldModel)
        {
            throw new NotImplementedException();
        }
    }
}
