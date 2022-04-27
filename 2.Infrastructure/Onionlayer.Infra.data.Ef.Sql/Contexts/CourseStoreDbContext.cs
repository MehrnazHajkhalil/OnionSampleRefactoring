
using Microsoft.EntityFrameworkCore;
using OnionSample.Core.Domain.Courses;
using OnionSample.Core.Domain.Orders;
using OnionSample.Core.Domain.Tags;
using OnionSample.Core.Domain.Teachers;


namespace OnionSample.Infra.data.Ef.Sql.Contexts;

public class CourseStoreDbContext : DbContext
{

    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseComment> CourseComments { get; set; }
    public DbSet<CourseTeacher> CourseTeachers { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public CourseStoreDbContext(DbContextOptions<CourseStoreDbContext> options) : base(options)
    {
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        //configurationBuilder.Properties<string>().HaveMaxLength(100);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        //قرار دادن فلوینت های کلی برای تمام اینتیتی ها اعمال بشه مثلا IsDeleted
        modelBuilder.Entity<Course>().HasQueryFilter(c => !c.IsDeleted);
    }

}