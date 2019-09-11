namespace ProductCatalog.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductCatalog_v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Telefone", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "Telefone");
        }
    }
}
