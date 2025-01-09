using CURD.Core.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL.Configurations;
public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
{
    public void Configure(EntityTypeBuilder<BlogCategory> builder)
    {
        builder.HasOne(x => x.Category)
            .WithMany(x => x.BlogCategories)
            .HasForeignKey(x => x.CategoryId);

        builder.HasOne(x => x.Blog)
            .WithMany(x => x.BlogCategories)
            .HasForeignKey(x => x.BlogId);

        builder.Ignore(x => x.IsDeleted);


    }
}
