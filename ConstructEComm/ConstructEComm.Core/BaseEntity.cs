
using System;
namespace ConstructEComm.Core
{
    public abstract partial class BaseEntity
    {
        public int Id { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
