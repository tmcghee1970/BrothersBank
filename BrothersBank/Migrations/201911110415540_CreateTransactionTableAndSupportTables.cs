namespace BrothersBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTransactionTableAndSupportTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        AccountNumber = c.Int(nullable: false),
                        TransactionTypeId = c.String(),
                        TransactionDescription = c.String(),
                        TransactionDateTime = c.DateTime(nullable: false),
                        TransactionAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TransactionId);
            
            CreateTable(
                "dbo.TransactionTypes",
                c => new
                    {
                        TransactionTypeId = c.Int(nullable: false, identity: true),
                        TransactionTypeDescription = c.String(),
                    })
                .PrimaryKey(t => t.TransactionTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TransactionTypes");
            DropTable("dbo.Transactions");
        }
    }
}
