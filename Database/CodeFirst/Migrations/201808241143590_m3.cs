namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Village = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        Country = c.String(maxLength: 50),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        PasswordUser = c.String(nullable: false, maxLength: 50),
                        IDNP = c.Long(nullable: false),
                        Photo = c.String(maxLength: 400),
                        DateCreated = c.DateTime(nullable: false),
                        BirthDate = c.DateTime(),
                        Age = c.Int(),
                        Gender = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true)
                .Index(t => t.IDNP, unique: true);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false, maxLength: 200),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.EventsStudents",
                c => new
                    {
                        EventId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventId, t.StudentId })
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntryTime = c.DateTime(nullable: false),
                        ExitTime = c.DateTime(nullable: false),
                        Active = c.String(nullable: false, maxLength: 3),
                        Class = c.String(),
                        UserId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                        YearOfStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.YearOfStudies", t => t.YearOfStudyId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.GroupId)
                .Index(t => t.YearOfStudyId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcademicYear = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCourse = c.String(nullable: false, maxLength: 50),
                        GroupId = c.Int(nullable: false),
                        DateCreateCourse = c.DateTime(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CoursId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Value = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cours", t => t.CoursId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.CoursId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        EntryTime = c.DateTime(nullable: false),
                        ExitTime = c.DateTime(nullable: false),
                        Active = c.String(nullable: false, maxLength: 3),
                        Degree = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.YearOfStudies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BegginingYear = c.DateTime(nullable: false),
                        EndYear = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentEvents",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Event_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Event_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "Id", "dbo.Users");
            DropForeignKey("dbo.Students", "UserId", "dbo.Users");
            DropForeignKey("dbo.Events", "UserId", "dbo.Users");
            DropForeignKey("dbo.EventsStudents", "EventId", "dbo.Events");
            DropForeignKey("dbo.Students", "YearOfStudyId", "dbo.YearOfStudies");
            DropForeignKey("dbo.Marks", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Cours", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Marks", "CoursId", "dbo.Cours");
            DropForeignKey("dbo.Cours", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.EventsStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.StudentEvents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Addresses", "UserId", "dbo.Users");
            DropIndex("dbo.StudentEvents", new[] { "Event_Id" });
            DropIndex("dbo.StudentEvents", new[] { "Student_Id" });
            DropIndex("dbo.Teachers", new[] { "Id" });
            DropIndex("dbo.Marks", new[] { "StudentId" });
            DropIndex("dbo.Marks", new[] { "CoursId" });
            DropIndex("dbo.Cours", new[] { "TeacherId" });
            DropIndex("dbo.Cours", new[] { "GroupId" });
            DropIndex("dbo.Students", new[] { "YearOfStudyId" });
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.Students", new[] { "UserId" });
            DropIndex("dbo.EventsStudents", new[] { "StudentId" });
            DropIndex("dbo.EventsStudents", new[] { "EventId" });
            DropIndex("dbo.Events", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "IDNP" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Addresses", new[] { "UserId" });
            DropTable("dbo.StudentEvents");
            DropTable("dbo.YearOfStudies");
            DropTable("dbo.Teachers");
            DropTable("dbo.Marks");
            DropTable("dbo.Cours");
            DropTable("dbo.Groups");
            DropTable("dbo.Students");
            DropTable("dbo.EventsStudents");
            DropTable("dbo.Events");
            DropTable("dbo.Users");
            DropTable("dbo.Addresses");
        }
    }
}
