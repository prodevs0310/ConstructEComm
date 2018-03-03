using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructEComm.Data
{
    public class ConstructECommContext : DbContext, IDbContext
    {
        public ConstructECommContext()
            : base("name=ConstructECommConnection")
        {

        }
    }
}
