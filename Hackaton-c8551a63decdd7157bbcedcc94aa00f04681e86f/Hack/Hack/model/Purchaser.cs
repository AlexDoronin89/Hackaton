using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack.model
{
    internal class Purchaser:User
    {
        public int Id { get; set; }

        public virtual ICollection<Order> Orders { get; set; }=new List<Order>();
    }
}
