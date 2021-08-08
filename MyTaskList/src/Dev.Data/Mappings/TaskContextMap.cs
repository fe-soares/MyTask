using Dev.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Data.Mappings
{
    public class TaskContextMap : IEntityTypeConfiguration<TaskContext>
    {
        public void Configure(EntityTypeBuilder<TaskContext> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.TitleStep).HasColumnType("varchar(200)");

            builder.Property(p => p.ContextStep).HasColumnType("varchar(200)");

            builder.Property(p => p.Status).HasColumnType("Integer(1)");

            builder.ToTable("M_CONTEXT_TASK");
        }
    }
}
