using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Shoes.Configurations
{
    public class SliderHomeConfigurations : IEntityTypeConfiguration<SliderHome>
    {
        public void Configure(EntityTypeBuilder<SliderHome> builder)
        {
            builder.ToTable("SliderHome");
            builder.HasKey(t => new { t.SliderId });



        }
    }
}
