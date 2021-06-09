using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Abstract;

namespace www.yasinkaya.org.Entities.Concrete
{
    public class User : IdentityUser<int>
    {

        public string Picture { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
