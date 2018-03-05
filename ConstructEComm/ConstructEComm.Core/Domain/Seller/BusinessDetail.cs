
namespace ConstructEComm.Core.Domain.Seller
{
    public class BusinessDetail
    {
        public string BusinessName { get; set; }

        public string GSTIN { get; set; }

        public byte[] GstinImage { get; set; }

        public byte[] TAN { get; set; }

        public byte[] CIN { get; set; }
    }
}
