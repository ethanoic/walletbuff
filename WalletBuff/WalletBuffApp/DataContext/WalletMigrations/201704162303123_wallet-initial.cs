namespace WalletBuffApp.DataContext.WalletMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class walletinitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccount",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        BankCode = c.String(maxLength: 6),
                        BranchCode = c.String(maxLength: 6),
                        Name = c.String(maxLength: 255),
                        Currency = c.String(maxLength: 3),
                        AccountType = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(maxLength: 500),
                        DateTime = c.DateTime(nullable: false),
                        TransactionType = c.Int(),
                        BankAccount_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BankAccount", t => t.BankAccount_ID)
                .Index(t => t.BankAccount_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaction", "BankAccount_ID", "dbo.BankAccount");
            DropIndex("dbo.Transaction", new[] { "BankAccount_ID" });
            DropTable("dbo.Transaction");
            DropTable("dbo.BankAccount");
        }
    }
}
