using Dev.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Data.Mappings
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.TaskContext).WithOne(p => p.Task).HasForeignKey(p => p.TaskId);

            builder.Property(x => x.Status).HasColumnType("Integer(1)");

            builder.ToTable("M_TASK");
        }
    }
}
