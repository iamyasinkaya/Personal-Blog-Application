using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.yasinkaya.org.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable //garbage collection 'a yardımcı oluyoruz. 
    {
        IArticleRepository Articles { get; } // unitofwork.Articles
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
       
        /*
         * Örnek;
         * _unitOfWork.Users.AddAsync(user);
         * _unitOfWork.Categories.AddAsync(category);
         * _unitofWork.SaveAsync();
         * 
         * Yukarıdaki biri hata alırsa, kayıt işlemi yapmayacak ve böylikle hatalı işlemden kaçınmış olacağız!
         */
        Task<int> SaveAsync();
    }
}
