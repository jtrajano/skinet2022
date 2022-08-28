using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p=>p.PictureUrl).IsRequired().HasMaxLength(189);
            builder.Property(p=>p.Description).IsRequired();
            builder.Property(p=>p.Price).HasColumnType("decimal(18,2)");
            builder.HasOne(p=>p.ProductBrand).WithMany().HasForeignKey(k=>k.ProductBrandId);
            builder.HasOne(p=>p.ProductType).WithMany().HasForeignKey(k=>k.ProductTypeId);

        }
    }
}