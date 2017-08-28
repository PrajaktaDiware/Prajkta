namespace Assignment6.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtableall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emp1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.Long(nullable: false),
                        MaritalStatus = c.Boolean(nullable: false),
                        State = c.Int(nullable: false),
                        City = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                        Abbr = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.States");
            DropTable("dbo.Cities");
            DropTable("dbo.Emp1");
        }
    }
}
