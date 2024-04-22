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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m=>m.ProductId);

            builder.Property(m=>m.Name).IsRequired().HasMaxLength(100);

            //builder.Property(m=>m.DateAdded).HasDefaultValueSql("getdate()");  // mssql
            // builder.Property(m=>m.DateAdded).HasDefaultValueSql ("date('now')");   // sqlite            
        }
    }
}