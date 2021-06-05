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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id); //Primary Key
            builder.Property(a => a.Id).ValueGeneratedOnAdd(); // 1'er 1'er artmasını istedim.
            builder.Property(a => a.Title).HasMaxLength(150); // 150 karakter olmasını istedim.
            builder.Property(a => a.Title).IsRequired(true); // Boş geçilemez.
            builder.Property(a => a.Content).IsRequired(true);
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)"); // Maksimum değerde alabilmesini istedim.
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50).IsRequired();
            builder.Property(a => a.SeoDesc).HasMaxLength(150).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired().HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired().HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId); // 1-N ilişkiyi kurmuş oldum.
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    Thumbnail = "Default.jpg",
                    SeoDesc = "C# 9.0 ve .NET 5 Yenilikleri",
                    SeoTags = "C#,C# 9.05, .NET 5, .NET Framework",
                    SeoAuthor = "Yasin KAYA",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                    UserId = 1,
                    ViewsCount = 100,
                    CommentCount = 1

                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "C++ 11 ve 19 Yenilikler",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                    Thumbnail = "Default.jpg",
                    SeoDesc = "C++ 11 ve 19 Yenilikler",
                    SeoTags = "C++, C++ 19, C++ 11",
                    SeoAuthor = "Yasin KAYA",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "C++ 11 ve 19 Yenilikler",
                    UserId = 1,
                    ViewsCount = 250,
                    CommentCount = 1

                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Javascript ES2019 ve ES2020 Yenilikleri",
                    Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.",
                    Thumbnail = "Default.jpg",
                    SeoDesc = "Javascript ES2019 ve ES2020 Yenilikleri",
                    SeoTags = "Javascript, Js",
                    SeoAuthor = "Yasin KAYA",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "Javascript ES2019 ve ES2020 Yenilikleri",
                    UserId = 1,
                    ViewsCount = 541,
                    CommentCount = 1

                });
        }
    }
}
