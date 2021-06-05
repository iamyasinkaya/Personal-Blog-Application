using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Entities.Dtos;

namespace www.yasinkaya.org.Services.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
