namespace CSharpEducation301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            // Veritabanına bir data eklediğimde update etmek için burayı kullanır
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            // Veritabanından bir data sildiğimde update etmek için burayı kullanır
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}
