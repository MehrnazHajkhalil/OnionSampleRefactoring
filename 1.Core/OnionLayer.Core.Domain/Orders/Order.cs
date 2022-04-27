using OnionSample.Core.Domain.BaseEntities;
using OnionSample.Core.Domain.Courses;

namespace OnionSample.Core.Domain.Orders;

public class Order:BaseEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public DateTime OrderDate { get; set; }
    public string CustomerEmail { get; set; }
    public int Price { get; set; }

}