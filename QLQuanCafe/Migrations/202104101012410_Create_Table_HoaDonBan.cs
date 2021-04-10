namespace QLQuanCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HoaDonBan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDonBans",
                c => new
                    {
                        MaHDB = c.String(nullable: false, maxLength: 128),
                        MaMon = c.String(),
                        DonGia = c.String(),
                        SoLuong = c.String(),
                        ThanhTien = c.String(),
                    })
                .PrimaryKey(t => t.MaHDB);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoaDonBans");
        }
    }
}
