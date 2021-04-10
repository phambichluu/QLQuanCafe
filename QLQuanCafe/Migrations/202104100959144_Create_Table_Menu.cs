namespace QLQuanCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Menu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MaMon = c.String(nullable: false, maxLength: 128),
                        TenMon = c.String(),
                        DonGia = c.String(),
                    })
                .PrimaryKey(t => t.MaMon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Menus");
        }
    }
}
