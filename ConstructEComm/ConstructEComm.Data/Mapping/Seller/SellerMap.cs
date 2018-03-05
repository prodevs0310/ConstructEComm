
using System;
namespace ConstructEComm.Data.Mapping.Seller
{
    public class SellerMap : ConstructECommTypeConfiguration<ConstructEComm.Core.Domain.Seller.Seller>
    {
        public SellerMap()
        {
            this.ToTable("Seller");
            this.HasKey<int>(x => x.Id);
            this.Property(x => x.ModifiedOn);
            this.Property(x => x.CreatedOn);
            this.Property(x => x.BusinessDetail.BusinessName).IsRequired().HasMaxLength(100);
            this.Property(x => x.BusinessDetail.GstinImage).IsRequired();
            this.Property(x => x.BusinessDetail.CIN).IsRequired();
            this.Property(x => x.BusinessDetail.TAN).IsRequired();
        }
    }
}
