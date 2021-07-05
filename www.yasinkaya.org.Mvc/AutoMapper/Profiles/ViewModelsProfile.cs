using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.ComplexTypes;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Mvc.Areas.Admin.Models;
using www.yasinkaya.org.Mvc.Helpers.Abstract;

namespace www.yasinkaya.org.Mvc.AutoMapper.Profiles
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile(IImageHelper imageHelper)
        {
            CreateMap<ArticleAddViewModel, ArticleAddDto>().ForMember(dest => dest.Thumbnail, opt => opt.MapFrom(x => imageHelper.Upload(x.Title, x.Thumbnail, PictureType.Post, null)));
            CreateMap<ArticleUpdateDto, ArticleUpdateViewModel>().ReverseMap().ForMember(dest => dest.Thumbnail, opt => opt.MapFrom(x => imageHelper.Upload(x.Title, x.ThumbnailFile, PictureType.Post, null)));
            CreateMap<ArticleRightSideBarWidgetOptions, ArticleRightSideBarWidgetOptionsViewModel>();
        }
    }
}
