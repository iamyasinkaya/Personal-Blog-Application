using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.ComplexTypes;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Mvc.Helpers.Abstract;

namespace www.yasinkaya.org.Mvc.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile(IImageHelper imageHelper)
        {
            CreateMap<UserAddDto, User>().ForMember(dest => dest.Picture, opt => opt.MapFrom(x => imageHelper.Upload(x.UserName, x.PictureFile, PictureType.User, null)));
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
