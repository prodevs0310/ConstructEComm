
namespace ConstructEComm.Core.Domain.Seller
{
    public class BusinessDetail
    {
        public string BusinessName { get; set; }

        public byte[] GstinImage { get; set; }

        public short No_Gstin { get; set; }

        public byte[] TAN { get; set; }

        public byte[] CIN { get; set; }

        public byte[] Signature { get; set; }

        public string Reg_Biz_Addr1 { get; set; }

        public string Reg_Biz_Addr2 { get; set; }

        public string Reg_Biz_Pincode { get; set; }

        public string Reg_Biz_City { get; set; }

        public string Reg_Biz_State { get; set; }
    }
}
