using OnionSample.Core.Domain.BaseEntities;
using OnionSample.Core.Domain.Courses;

namespace OnionSample.Core.Domain.Tags;

public class Tag:BaseEntity
{
    public string TagName { get; set; }
    public List<Course> Courses { get; set; }
}
