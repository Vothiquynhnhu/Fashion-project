using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;

namespace Web_Shoes.Configurations
{
    public class SubscribersConfigurations : IEntityTypeConfiguration<Subscribers>
    {
        public void Configure(EntityTypeBuilder<Subscribers> builder)
        {
            builder.ToTable("Subsriber");
            builder.HasKey(t => new { t.Subs_Id });



        }
    }
}
