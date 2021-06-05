using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.yasinkaya.org.Shared.Entities.Abstract
{
    public abstract class EntityBase // Bu sınıf public ve abstract çünkü base değerler, diğer sınıflarda değişikliğie uğramasını isteyebiliriz!
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; // Örneğin oluşturulduğu an değiştirilmesini istiyorum. virtual verdim // override CreatedDate = new DateTime(2020/01/01);
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false; //ilk değerini false atıyorum, bir şey oluşturulduğunda hayır silinmedi değerini veriyorum.
        public virtual bool IsActive { get; set; } = true;  // true: default value
        public virtual string CreatedByName { get; set; } = "Admin"; //default değer Admin
        public virtual string ModifiedByName { get; set; } = "Admin"; // default değer Admin
        public virtual string Note { get; set; }

    }
}
