namespace FirstMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MappedSPtoDepartmentEntity : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Department_Insert",
                p => new
                    {
                        DepratmentName = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Departments]([DepratmentName])
                      VALUES (@DepratmentName)"
            );
            
            CreateStoredProcedure(
                "dbo.Department_Update",
                p => new
                    {
                        DepartmentID = p.Int(),
                        DepratmentName = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Departments]
                      SET [DepratmentName] = @DepratmentName
                      WHERE ([DepartmentID] = @DepartmentID)"
            );
            
            CreateStoredProcedure(
                "dbo.Department_Delete",
                p => new
                    {
                        DepartmentID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Departments]
                      WHERE ([DepartmentID] = @DepartmentID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Department_Delete");
            DropStoredProcedure("dbo.Department_Update");
            DropStoredProcedure("dbo.Department_Insert");
        }
    }
}
