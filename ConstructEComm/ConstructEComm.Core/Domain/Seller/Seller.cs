using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructEComm.Core.Domain.Seller
{
    public class Seller : BaseEntity 
    {
        public Seller()
        {
            this.BusinessDetail = new BusinessDetail();
        }

        public BusinessDetail BusinessDetail { get; set; }
    }
}
