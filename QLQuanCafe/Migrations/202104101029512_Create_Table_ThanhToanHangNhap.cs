namespace QLQuanCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ThanhToanHangNhap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThanhToanHangNhaps",
                c => new
                    {
                        MaTTHangNhap = c.String(nullable: false, maxLength: 128),
                        NgayTT = c.String(),
                        MaNV = c.String(),
                        ThanhTien = c.String(),
                    })
                .PrimaryKey(t => t.MaTTHangNhap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThanhToanHangNhaps");
        }
    }
}
