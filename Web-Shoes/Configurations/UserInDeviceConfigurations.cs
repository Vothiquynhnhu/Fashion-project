using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web_Shoes.Entity;

namespace Web_Shoes.Configurations
{
    public class UserInDeviceConfigurations : IEntityTypeConfiguration<UserInDevice>
    {
        public void Configure(EntityTypeBuilder<UserInDevice> builder)
        {
            builder.ToTable("UserInDevice");
            builder.HasKey(t => new { t.UiD_DeviceId, t.UiD_UserId });

            builder.HasOne(t => t.AppUser).WithMany(ur => ur.UserInDevicesU)
     .HasForeignKey(pc => pc.UiD_UserId);
            builder.HasOne(t => t.Device).WithMany(ur => ur.UserInDevicesD)
     .HasForeignKey(pc => pc.UiD_DeviceId);


            //       builder.HasOne(t => t.ProductsRIP).WithMany(ur => ur.ReviewInproductP)
            //.HasForeignKey(pc => pc.rip_ProductId);
            //       builder.HasOne(t => t.ReviewsRIP).WithMany(ur => ur.ReviewInproductR)
            //.HasForeignKey(pc => pc.rip_ReviewId);
        }
    }
}
