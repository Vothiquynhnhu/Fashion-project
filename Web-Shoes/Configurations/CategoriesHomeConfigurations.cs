using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Fashion.Configurations
{
    public class CategoriesHomeConfigurations : IEntityTypeConfiguration<CategoriesHome>
    {
        public void Configure(EntityTypeBuilder<CategoriesHome> builder)
        {
            builder.ToTable("CategoriesHome");
            builder.HasKey(t => new { t.CategoriesHomeId });
        }
    }
}
