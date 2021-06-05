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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.EmailAddress).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.EmailAddress).IsUnique(); //Email adresi uniq ve ikinci kez aynı mail ile kayıt olunamıyor.
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.UserName).IsUnique(); // userName adresi uniq ve ikinci kez aynı username ile kayıt olunamıyor.
            builder.Property(u => u.PasswordHash).IsRequired().HasColumnType("VARBINARY(500)");
            builder.Property(u => u.Description).HasMaxLength(500);
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Picture).IsRequired().HasMaxLength(250);
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.Property(u => u.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifiedDate).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.Note).HasMaxLength(500);
            builder.ToTable("Users");
            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Yasin",
                LastName = "Kaya",
                UserName = "Yasin Kaya",
                EmailAddress ="yasinkaya@yasinkaya.org",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                ModifiedByName ="InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Description = "Ilk Kullanıcı",
                Note ="Ilk Kullanıcı",
                PasswordHash = Encoding.ASCII.GetBytes("9d37c93595cd26172eaf278b1b81bebe")
            });

        }
    }
}
