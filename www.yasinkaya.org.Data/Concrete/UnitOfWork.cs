using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Data.Abstract;
using www.yasinkaya.org.Data.Concrete.EntityFramework;
using www.yasinkaya.org.Data.Concrete.EntityFramework.Contexts;

namespace www.yasinkaya.org.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly YasinKayaContext _context;
        private EfArticleRepository _efArticleRepository;
        private EfCategoryRepository _efCategoryRepository;
        private EfCommentRepository _efCommentRepository;
       

        public UnitOfWork(YasinKayaContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => _efArticleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository Categories => _efCategoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Commetns => _efCommentRepository ?? new EfCommentRepository(_context);

   

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
