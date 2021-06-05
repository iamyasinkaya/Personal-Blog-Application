using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Shared.Data.Abstract;

namespace www.yasinkaya.org.Data.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}
