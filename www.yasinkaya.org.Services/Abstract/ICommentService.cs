using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Utilities.Result.Abstract;

namespace www.yasinkaya.org.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<int>> CountAsync();

        Task<IDataResult<int>> CountByIsDeletedAsync();
    }
}
