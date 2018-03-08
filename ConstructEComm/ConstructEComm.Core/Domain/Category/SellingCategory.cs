
namespace ConstructEComm.Core.Domain.Category
{
    public partial class SellingCategory : BaseEntity
    {
        public string Name { get; set; }

        public int Parent { get; set; }

        public string Description { get; set; }
    }
}
