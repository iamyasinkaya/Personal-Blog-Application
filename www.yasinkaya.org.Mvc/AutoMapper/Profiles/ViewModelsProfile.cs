using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Mvc.Areas.Admin.Models;

namespace www.yasinkaya.org.Mvc.AutoMapper.Profiles
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<ArticleAddViewModel, ArticleAddDto>();
        }
    }
}
