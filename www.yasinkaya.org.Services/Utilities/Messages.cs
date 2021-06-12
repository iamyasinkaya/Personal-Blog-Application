using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.yasinkaya.org.Services.Utilities
{
    public static class Messages
    {
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Kategoriler Bulunamadı!";
                return "Kategori Bulunamadı";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori veritabanından silinmiştir.";
            }
        }

        public static class Article
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Makaleler Bulunamadı!";
                return "Makale Bulunamadı";
            }
            public static string Add(string articleName)
            {
                return $"{articleName} adlı makale eklenmiştir.";
            }

            public static string Update(string articleName)
            {
                return $"{articleName} adlı makale güncellenmiştir.";
            }
            public static string Delete(string articleName)
            {
                return $"{articleName} adlı makale silinmiştir.";
            }
            public static string HardDelete(string articleName)
            {
                return $"{articleName} adlı makale veritabanından silinmiştir.";
            }
        }
    }
}
