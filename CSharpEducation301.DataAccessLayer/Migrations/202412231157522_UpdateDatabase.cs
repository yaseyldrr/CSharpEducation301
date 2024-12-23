namespace CSharpEducation301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropColumn("dbo.Products", "CategoryId");
            RenameColumn(table: "dbo.Products", name: "Category_CategoryId", newName: "CategoryId");
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Categories", "CategoryId");
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Products", "CategoryId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Categories", "CategoryId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Categories", "CategoryId");
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "Category_CategoryId");
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Category_CategoryId");
            AddForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
