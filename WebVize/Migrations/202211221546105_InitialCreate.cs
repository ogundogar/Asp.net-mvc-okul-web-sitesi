 namespace WebVize.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Duyurulars",
                c => new
                    {
                        DuyuruID = c.Int(nullable: false, identity: true),
                        DuyuruBasligi = c.String(),
                        Duyuru = c.String(),
                        DuyuruTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DuyuruID);
            
            CreateTable(
                "Adminlers",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropTable("Adminlers");
            DropTable("Duyurulars");
        }
    }
}
