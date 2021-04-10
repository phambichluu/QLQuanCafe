namespace QLQuanCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhapHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhapHangs",
                c => new
                    {
                        MaNhapHang = c.String(nullable: false, maxLength: 128),
                        NgayNhapHang = c.String(),
                        LoaiHangHoa = c.String(),
                        DonGia = c.String(),
                        SoLuong = c.String(),
                        ThanhTien = c.String(),
                    })
                .PrimaryKey(t => t.MaNhapHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhapHangs");
        }
    }
}
