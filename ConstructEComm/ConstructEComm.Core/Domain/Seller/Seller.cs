
namespace ConstructEComm.Core.Domain.Seller
{
    public class Seller : BaseEntity 
    {
        public Seller()
        {
            this.BusinessDetail = new BusinessDetail();
            this.BankDetail = new BankDetail();
            this.StoreDetail = new StoreDetail();
        }

        public BusinessDetail BusinessDetail { get; set; }

        public BankDetail BankDetail { get; set; }

        public StoreDetail StoreDetail { get; set; }
    }
}
