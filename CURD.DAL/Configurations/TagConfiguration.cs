using CURD.Core.Entityes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL.Configurations;
public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        
        builder.HasKey(t => t.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(t => t.TagName)
            .IsRequired()  
            .HasMaxLength(50); 

        builder.HasMany(t => t.Products)  
            .WithOne()  
            .HasForeignKey(tp => tp.TagId)  
            .OnDelete(DeleteBehavior.Cascade); 

    }
}
