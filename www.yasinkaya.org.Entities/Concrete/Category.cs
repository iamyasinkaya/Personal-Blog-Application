using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Abstract;

namespace www.yasinkaya.org.Entities.Concrete
{
    public class Category : EntityBase, IEntity
    {
        /// <summary>
        /// Category Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ICollection:IEnumerable arayüzünü kullanır. Farklı olarak;
        /// Add element ekleyen
        /// Remove element silen
        /// Contains ​elementin varlığını sınayan
        /// metodları vardır.
        /// </summary>
        public ICollection<Article> Articles { get; set; }


    }
}
