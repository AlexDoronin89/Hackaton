using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETP.Model
{
    class Supplier :User
    {
        public int Id { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
