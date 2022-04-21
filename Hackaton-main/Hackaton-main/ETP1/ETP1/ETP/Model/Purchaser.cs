using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETP.Model
{
    class Purchaser:User
    {
        public User User { get; set; }

        public int Id { get; set; }
    }
}
