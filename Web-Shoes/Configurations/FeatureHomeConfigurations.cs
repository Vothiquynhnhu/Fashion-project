using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Shoes.Configurations
{
    public class FeatureHomeConfigurations : IEntityTypeConfiguration<FeatureHome>
    {
        public void Configure(EntityTypeBuilder<FeatureHome> builder)
        {
            builder.ToTable("FeatureHome");
            builder.HasKey(t => new { t.FeatureHomeId });

        }
    }
}
