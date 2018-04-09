namespace FirstMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mappeduserdefinedSP : DbMigration
    {
        public override void Up()
        {
            RenameStoredProcedure(name: "dbo.Department_Insert", newName: "stp_InsertDepartment");
        }
        
        public override void Down()
        {
            RenameStoredProcedure(name: "dbo.stp_InsertDepartment", newName: "Department_Insert");
        }
    }
}
