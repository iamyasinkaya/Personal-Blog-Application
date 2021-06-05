﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Data.Abstract;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Shared.Data.Concrete.EntityFramework;

namespace www.yasinkaya.org.Data.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
