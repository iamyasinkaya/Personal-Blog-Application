﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Shared.Utilities.Result.Abstract;

namespace www.yasinkaya.org.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<CommentDto>> GetAsync(int commentId);
        Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDtoAsync(int commentId);
        Task<IDataResult<CommentListDto>> GetAllAsync();
        Task<IDataResult<CommentListDto>> GetAllByDeletedAsync();
        Task<IDataResult<CommentListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<CommentListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CommentDto>> AddAsync(CommentAddDto commentAddDto);
        Task<IDataResult<CommentDto>> UpdateAsync(CommentUpdateDto commentUpdateDto, string modifiedByName);
        Task<IDataResult<CommentDto>> DeleteAsync(int commentId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int commentId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
