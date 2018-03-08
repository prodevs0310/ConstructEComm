using ConstructEComm.Core.Domain.Category;

namespace ConstructEComm.Data.Mapping.Category
{
    public partial class CategoryMap : ConstructECommTypeConfiguration<SellingCategory>
    {
        public CategoryMap()
        {
            this.ToTable("Category");
            this.HasKey<int>(x => x.Id);
            this.Property(x => x.Name).IsRequired().HasMaxLength(100);
            this.Property(x => x.CreatedOn);
            this.Property(x => x.ModifiedOn);
            this.Property(x => x.Description).HasMaxLength(500);
        }
    }
}
