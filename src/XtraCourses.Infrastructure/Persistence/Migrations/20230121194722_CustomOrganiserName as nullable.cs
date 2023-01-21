using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraCourses.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CustomOrganiserNameasnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourseName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProjectName = table.Column<string>(type: "TEXT", nullable: false),
                    ProjectDetailsCourseStartedDate = table.Column<string>(name: "ProjectDetails_CourseStartedDate", type: "TEXT", nullable: false, defaultValue: ""),
                    ProjectDetailsOpenedLessonsCount = table.Column<int>(name: "ProjectDetails_OpenedLessonsCount", type: "INTEGER", nullable: false, defaultValue: 0),
                    ProjectDetailsCompletedDate = table.Column<string>(name: "ProjectDetails_CompletedDate", type: "TEXT", nullable: false, defaultValue: ""),
                    ProjectDetailsCompletedLessonsCount = table.Column<int>(name: "ProjectDetails_CompletedLessonsCount", type: "INTEGER", nullable: false, defaultValue: 0),
                    ProjectDetailsTotalLessonsCount = table.Column<int>(name: "ProjectDetails_TotalLessonsCount", type: "INTEGER", nullable: false, defaultValue: 0),
                    ProjectDetailsHaveNotStarted = table.Column<string>(name: "ProjectDetails_HaveNotStarted", type: "TEXT", nullable: false, defaultValue: ""),
                    ProjectDetailsNotOnSchedule = table.Column<string>(name: "ProjectDetails_NotOnSchedule", type: "TEXT", nullable: false, defaultValue: ""),
                    ProjectDetailsHaveStarted = table.Column<string>(name: "ProjectDetails_HaveStarted", type: "TEXT", nullable: false, defaultValue: ""),
                    ProjectDetailsQuizScore = table.Column<int>(name: "ProjectDetails_QuizScore", type: "INTEGER", nullable: false, defaultValue: 0),
                    ProjectDetailsQuizScoreTotal = table.Column<int>(name: "ProjectDetails_QuizScoreTotal", type: "INTEGER", nullable: false, defaultValue: 0),
                    ProjectDetailsCertificateTitle = table.Column<string>(name: "ProjectDetails_CertificateTitle", type: "TEXT", nullable: false, defaultValue: ""),
                    ProjectDetailsIsPassed = table.Column<bool>(name: "ProjectDetails_IsPassed", type: "INTEGER", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Person = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Upn = table.Column<string>(type: "TEXT", nullable: false),
                    Department = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    ImportTag = table.Column<string>(type: "TEXT", nullable: false),
                    Mobile = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Person);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
