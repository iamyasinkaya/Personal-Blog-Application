using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Shared.Utilities.Result.Abstract;

namespace www.yasinkaya.org.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);

        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);

        Task<IDataResult<CategoryListDto>> GetAllAsync();

        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();

        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync();

        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto,string createdByName);

        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto,string modifiedByName);

        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName); 

        Task<IResult> HardDeleteAsync(int categoryId);
    }
}
