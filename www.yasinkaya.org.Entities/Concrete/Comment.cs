using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Abstract;

namespace www.yasinkaya.org.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
