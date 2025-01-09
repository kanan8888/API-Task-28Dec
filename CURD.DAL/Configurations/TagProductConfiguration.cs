using CURD.Core.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL.Configurations;
public class TagProductConfiguration : IEntityTypeConfiguration<TagProduct>
{
    public void Configure(EntityTypeBuilder<TagProduct> builder)
    {

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(tp => tp.Product)  
            .WithMany(p => p.Tags)  
            .HasForeignKey(tp => tp.ProductId)  
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(tp => tp.Tag)  
            .WithMany(t => t.Products)  
            .HasForeignKey(tp => tp.TagId)  
            .OnDelete(DeleteBehavior.Cascade);

        builder.Ignore(x => x.IsDeleted);

    }
}
