using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Abstract;

namespace www.yasinkaya.org.Entities.Concrete
{
    public class User : EntityBase, IEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public byte[] PasswordHash { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public string Picture { get; set; }

        public string Description { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
