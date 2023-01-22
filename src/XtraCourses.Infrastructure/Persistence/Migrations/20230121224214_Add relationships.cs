using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XtraCourses.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addrelationships : Migration
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
                name: "Users",
                columns: table => new
                {
                    Person = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Upn = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    ImportTag = table.Column<string>(type: "TEXT", nullable: true),
                    Mobile = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Person);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProjectId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PersonId = table.Column<string>(type: "TEXT", nullable: false),
                    ProjectName = table.Column<string>(type: "TEXT", nullable: false),
                    ProjectDetailsCourseStartedDate = table.Column<string>(name: "ProjectDetails_CourseStartedDate", type: "TEXT", nullable: true, defaultValue: ""),
                    ProjectDetailsOpenedLessonsCount = table.Column<int>(name: "ProjectDetails_OpenedLessonsCount", type: "INTEGER", nullable: true, defaultValue: 0),
                    ProjectDetailsCompletedDate = table.Column<string>(name: "ProjectDetails_CompletedDate", type: "TEXT", nullable: true, defaultValue: ""),
                    ProjectDetailsCompletedLessonsCount = table.Column<int>(name: "ProjectDetails_CompletedLessonsCount", type: "INTEGER", nullable: true, defaultValue: 0),
                    ProjectDetailsTotalLessonsCount = table.Column<int>(name: "ProjectDetails_TotalLessonsCount", type: "INTEGER", nullable: true, defaultValue: 0),
                    ProjectDetailsHaveNotStarted = table.Column<string>(name: "ProjectDetails_HaveNotStarted", type: "TEXT", nullable: true, defaultValue: ""),
                    ProjectDetailsNotOnSchedule = table.Column<string>(name: "ProjectDetails_NotOnSchedule", type: "TEXT", nullable: true, defaultValue: ""),
                    ProjectDetailsHaveStarted = table.Column<string>(name: "ProjectDetails_HaveStarted", type: "TEXT", nullable: true, defaultValue: ""),
                    ProjectDetailsQuizScore = table.Column<int>(name: "ProjectDetails_QuizScore", type: "INTEGER", nullable: true, defaultValue: 0),
                    ProjectDetailsQuizScoreTotal = table.Column<int>(name: "ProjectDetails_QuizScoreTotal", type: "INTEGER", nullable: true, defaultValue: 0),
                    ProjectDetailsCertificateTitle = table.Column<string>(name: "ProjectDetails_CertificateTitle", type: "TEXT", nullable: true, defaultValue: ""),
                    ProjectDetailsIsPassed = table.Column<bool>(name: "ProjectDetails_IsPassed", type: "INTEGER", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Users_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Users",
                        principalColumn: "Person",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CourseId",
                table: "Projects",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PersonId",
                table: "Projects",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
