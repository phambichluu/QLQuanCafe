namespace QLQuanCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ThanhToan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThanhToans",
                c => new
                    {
                        MaTT = c.String(nullable: false, maxLength: 128),
                        NgayTT = c.String(),
                        MaNV = c.String(),
                        MaKH = c.String(),
                        ThanhTien = c.String(),
                    })
                .PrimaryKey(t => t.MaTT);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThanhToans");
        }
    }
}
