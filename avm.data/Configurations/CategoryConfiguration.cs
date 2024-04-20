using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using avm.entity;
using avm.data.Abstract;


namespace avm.data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
         public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(m=>m.CategoryId);

            builder.Property(m=>m.Name).IsRequired().HasMaxLength(100);
            
        }
    }
}