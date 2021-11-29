﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Entity;

namespace Web_Fashion.Configurations
{
    public class ProductInCartConfigurations : IEntityTypeConfiguration<ProductInCart>
    {
        public void Configure(EntityTypeBuilder<ProductInCart> builder)
        {
            builder.ToTable("ProductInCart");
            builder.HasKey(t => new { t.pic_CartId, t.pic_ProductId ,t.pic_Id});
            builder.HasOne(t => t.ProductsPICart).WithMany(ur => ur.ProductInCartP)
     .HasForeignKey(pc => pc.pic_ProductId);
            builder.HasOne(t => t.CartPICart).WithMany(ur => ur.ProductInCartC)
     .HasForeignKey(pc => pc.pic_CartId);
           
        }
    }
}
