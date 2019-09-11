namespace ProductCatalog.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductCatalog_v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Estoque", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Estoque");
        }
    }
}
