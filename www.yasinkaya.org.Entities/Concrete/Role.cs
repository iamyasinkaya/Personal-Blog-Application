using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Abstract;

namespace www.yasinkaya.org.Entities.Concrete
{
    public class Role : EntityBase, IEntity
    {
        /// <summary>
        /// Role Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// User
        /// </summary>
        public ICollection<User> Users { get; set; }
    }
}
