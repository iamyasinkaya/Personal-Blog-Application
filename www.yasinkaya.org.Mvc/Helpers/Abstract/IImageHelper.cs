﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.ComplexTypes;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Shared.Utilities.Result.Abstract;

namespace www.yasinkaya.org.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        string Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
