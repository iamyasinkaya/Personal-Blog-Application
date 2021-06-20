using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Data.Abstract;

namespace www.yasinkaya.org.Services.Concrete
{
    public class ManagerBase
    {
        public ManagerBase(IUnitOfWork unitOfWork,IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
            
        }
        protected IUnitOfWork UnitOfWork;
        protected IMapper Mapper { get; }

       
    }
}
