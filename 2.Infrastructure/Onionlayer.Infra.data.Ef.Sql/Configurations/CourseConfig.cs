﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionSample.Core.Domain.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Infra.data.Ef.Sql.Configurations;

public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(c => c.ImageUrl).IsRequired().HasMaxLength(1000);
        builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Description).IsRequired();
        builder.Property(c => c.ShortDescription).IsRequired().HasMaxLength(500);
    }
}