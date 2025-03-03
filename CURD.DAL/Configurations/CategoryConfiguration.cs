﻿using CURD.Core.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
    
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.CategoryName)
               .IsRequired()
               .HasMaxLength(20);

        builder.HasMany(x => x.Products)
               .WithOne()
               .HasForeignKey("CategoryId")
               .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Categories");
    }



}
