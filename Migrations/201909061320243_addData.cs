namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Students(FirstMidName, LastName, EnrollmentDate) Values ('Carson','Alexander', CAST(N'2005-09-01' as DateTime))");
            Sql("Insert Into Students(FirstMidName, LastName, EnrollmentDate) Values ('Meredith','Alonso', CAST(N'2002-09-01' as DateTime))");
            Sql("Insert Into Students(FirstMidName, LastName, EnrollmentDate) Values ('Arturo','Anand', CAST(N'2003-09-01' as DateTime))");
            Sql("Insert Into Students(FirstMidName, LastName, EnrollmentDate) Values ('Gytis','Barzdukas', CAST(N'2002-09-01' as DateTime))");
            Sql("Insert Into Students(FirstMidName, LastName, EnrollmentDate) Values ('Yan','Li', CAST(N'2002-09-01' as DateTime))");
            Sql("Insert Into Students(FirstMidName, LastName, EnrollmentDate) Values ('Laura','Norman', CAST(N'2003-09-01' as DateTime))");
            Sql("Insert Into Students(FirstMidName, LastName, EnrollmentDate) Values ('Nino','Olivetto', CAST(N'2005-09-01' as DateTime))");

            Sql("Insert Into Courses(CourseId, Title, Credits) Values (1050,'Chemistry', 3)");
            Sql("Insert Into Courses(CourseId, Title, Credits) Values (4022,'MicroEconomics', 3)");
            Sql("Insert Into Courses(CourseId, Title, Credits) Values (4041,'Macroeconomics', 3)");
            Sql("Insert Into Courses(CourseId, Title, Credits) Values (1045,'Calculus', 4)");
            Sql("Insert Into Courses(CourseId, Title, Credits) Values (3141,'Trigonometry', 4)");
            Sql("Insert Into Courses(CourseId, Title, Credits) Values (2021,'Compostion', 3)");
            Sql("Insert Into Courses(CourseId, Title, Credits) Values (2042,'Literature', 4)");

            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (1050, 1, 1)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (4022, 1, 3)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (4041, 1, 2)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (4041, 2, 2)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (1045, 2, 5)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (2021,2,  5)");
            Sql("Insert Into Enrollments(CourseId, StudentId) Values (1050, 3)");
            Sql("Insert Into Enrollments(CourseId, StudentId) Values (1050, 4)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (4022, 4, 5)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (4041, 5, 3)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (1045, 6, 1)");
            Sql("Insert Into Enrollments(CourseId, StudentId, Grade) Values (3141, 7, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
