
namespace ConstructEComm.Core.Domain.Seller
{
    public class BankDetail
    {
        public string AccountHolderName { get; set; }

        public string AccountNumber { get; set; }

        public string IFSCCode { get; set; }

        public string BankName { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Branch { get; set; }

        public string BusinessType { get; set; }

        public byte[] PersonalPAN { get; set; }

        public byte[] AddressProof { get; set; }

        public byte[] CancelledCheque { get; set; }
    }
}
