namespace BrothersBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAccountTableAndSupportTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountNumber = c.Int(nullable: false, identity: true),
                        AccountStatusCode = c.String(),
                        AccountTypeCode = c.String(),
                        CustomerId = c.Int(nullable: false),
                        CurrentBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BalanceAsOfDateTime = c.DateTime(nullable: false),
                        AccountOpenDate = c.DateTime(nullable: false),
                        AccountCloseDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountNumber);
            
            CreateTable(
                "dbo.AccountTypeFamilies",
                c => new
                    {
                        AccountTypeFamilyId = c.Int(nullable: false, identity: true),
                        AccountTypeFamilyName = c.String(),
                    })
                .PrimaryKey(t => t.AccountTypeFamilyId);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        AccountTypeCode = c.String(nullable: false, maxLength: 128),
                        AccountTypeFamilyId = c.Int(nullable: false),
                        AccountTypeName = c.String(),
                        AccountTypeDescription = c.String(),
                        MonthlyFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AnnualPercentageYield = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinimumOpeningDeposity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AccountTypeCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountTypes");
            DropTable("dbo.AccountTypeFamilies");
            DropTable("dbo.Accounts");
        }
    }
}
