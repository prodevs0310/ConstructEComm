namespace ConstructEComm.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Parent = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusinessDetail_BusinessName = c.String(nullable: false, maxLength: 100),
                        BusinessDetail_GstinImage = c.Binary(nullable: false),
                        BusinessDetail_No_Gstin = c.Short(nullable: false),
                        BusinessDetail_TAN = c.Binary(nullable: false),
                        BusinessDetail_CIN = c.Binary(nullable: false),
                        BusinessDetail_Signature = c.Binary(),
                        BusinessDetail_Reg_Biz_Addr1 = c.String(),
                        BusinessDetail_Reg_Biz_Addr2 = c.String(),
                        BusinessDetail_Reg_Biz_Pincode = c.String(),
                        BusinessDetail_Reg_Biz_City = c.String(),
                        BusinessDetail_Reg_Biz_State = c.String(),
                        BankDetail_AccountHolderName = c.String(),
                        BankDetail_AccountNumber = c.String(),
                        BankDetail_IFSCCode = c.String(),
                        BankDetail_BankName = c.String(),
                        BankDetail_State = c.String(),
                        BankDetail_City = c.String(),
                        BankDetail_Branch = c.String(),
                        BankDetail_BusinessType = c.String(),
                        BankDetail_PersonalPAN = c.Binary(),
                        BankDetail_AddressProof = c.Binary(),
                        BankDetail_CancelledCheque = c.Binary(),
                        StoreDetail_DisplayName = c.String(),
                        StoreDetail_BusinessDescription = c.String(),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Seller");
            DropTable("dbo.Category");
        }
    }
}
