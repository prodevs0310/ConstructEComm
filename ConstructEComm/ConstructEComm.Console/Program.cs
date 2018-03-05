using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructEComm.Core.Domain.Category;
using ConstructEComm.Data;

namespace ConstructEComm.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ConstructECommContext()) 
            {
                var input = context.Set<SellingCategory>().ToList();
            }
        }
    }
}
