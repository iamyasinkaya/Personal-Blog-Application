using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;

namespace www.yasinkaya.org.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Description).HasMaxLength(250);
            builder.Property(c => c.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Categories");
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "C#",
                    Description = "C# Program dili ile ilgili en güncel bilgiler yer almaktadır.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "C# Kategori",
                },
                new Category
                {
                    Id = 2,
                    Name = "C++",
                    Description = "C+ Program dili ile ilgili en güncel bilgiler yer almaktadır.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "C++ Kategori",
                }
                ,
                new Category
                {
                    Id = 3,
                    Name = "Javascript",
                    Description = "Javascript Program dili ile ilgili en güncel bilgiler yer almaktadır.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "Javascript Kategori",
                });
        }
    }
}
