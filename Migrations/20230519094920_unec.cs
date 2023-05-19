using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeachingLoadInfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class unec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LayoutInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    GridName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stream = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayoutInfos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ScientificDegrees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DegreeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScientificDegrees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ScientificNames",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScientificNames", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TLIncludeds",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseFirstSem = table.Column<int>(type: "int", nullable: false),
                    LectureFirstSem = table.Column<int>(type: "int", nullable: false),
                    LaboratoryFirstSem = table.Column<int>(type: "int", nullable: false),
                    RecommendationFirstSem = table.Column<int>(type: "int", nullable: false),
                    ExamFirstSem = table.Column<int>(type: "int", nullable: false),
                    FirstSemSum = table.Column<int>(type: "int", nullable: false),
                    ExerciseSecondSem = table.Column<int>(type: "int", nullable: false),
                    LectureSecondSem = table.Column<int>(type: "int", nullable: false),
                    LaboratorySecondSem = table.Column<int>(type: "int", nullable: false),
                    RecommendationSecondSem = table.Column<int>(type: "int", nullable: false),
                    ExamSecondSem = table.Column<int>(type: "int", nullable: false),
                    PrLeader = table.Column<int>(type: "int", nullable: false),
                    Practise = table.Column<int>(type: "int", nullable: false),
                    EPedTETedTTKITA = table.Column<int>(type: "int", nullable: false),
                    Thesis = table.Column<int>(type: "int", nullable: false),
                    MasterThesis = table.Column<int>(type: "int", nullable: false),
                    Doctorate = table.Column<int>(type: "int", nullable: false),
                    SecondSemSum = table.Column<int>(type: "int", nullable: false),
                    FinalResult = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLIncludeds", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorkTimes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkTimeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkTimeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkTimeFactor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTimes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TLExcludeds",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    ExerciseFirstSem = table.Column<int>(type: "int", nullable: false),
                    LectureFirstSem = table.Column<int>(type: "int", nullable: false),
                    LaboratoryFirstSem = table.Column<int>(type: "int", nullable: false),
                    RecommendationFirstSem = table.Column<int>(type: "int", nullable: false),
                    ExamFirstSem = table.Column<int>(type: "int", nullable: false),
                    FirstSemSum = table.Column<int>(type: "int", nullable: false),
                    ExerciseSecondSem = table.Column<int>(type: "int", nullable: false),
                    LectureSecondSem = table.Column<int>(type: "int", nullable: false),
                    LaboratorySecondSem = table.Column<int>(type: "int", nullable: false),
                    RecommendationSecondSem = table.Column<int>(type: "int", nullable: false),
                    ExamSecondSem = table.Column<int>(type: "int", nullable: false),
                    PrLeader = table.Column<int>(type: "int", nullable: false),
                    Practise = table.Column<int>(type: "int", nullable: false),
                    EPedTETedTTKITA = table.Column<int>(type: "int", nullable: false),
                    Thesis = table.Column<int>(type: "int", nullable: false),
                    MasterThesis = table.Column<int>(type: "int", nullable: false),
                    Doctorate = table.Column<int>(type: "int", nullable: false),
                    SecondSemSum = table.Column<int>(type: "int", nullable: false),
                    FinalResult = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLExcludeds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TLExcludeds_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderID = table.Column<int>(type: "int", nullable: false),
                    ScientificNameID = table.Column<int>(type: "int", nullable: false),
                    ScientificDegreeID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    ProfessionID = table.Column<int>(type: "int", nullable: false),
                    WorkTimeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherInfos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TeacherInfos_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherInfos_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherInfos_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherInfos_ScientificDegrees_ScientificDegreeID",
                        column: x => x.ScientificDegreeID,
                        principalTable: "ScientificDegrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherInfos_ScientificNames_ScientificNameID",
                        column: x => x.ScientificNameID,
                        principalTable: "ScientificNames",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherInfos_WorkTimes_WorkTimeID",
                        column: x => x.WorkTimeID,
                        principalTable: "WorkTimes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherInfoID = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTextBook = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_TeacherInfos_TeacherInfoID",
                        column: x => x.TeacherInfoID,
                        principalTable: "TeacherInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherInfoID = table.Column<int>(type: "int", nullable: false),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    IsLocal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Certificates_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Certificates_TeacherInfos_TeacherInfoID",
                        column: x => x.TeacherInfoID,
                        principalTable: "TeacherInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreferedSubjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherInfoID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferedSubjects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PreferedSubjects_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreferedSubjects_TeacherInfos_TeacherInfoID",
                        column: x => x.TeacherInfoID,
                        principalTable: "TeacherInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreviousJobs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherInfoID = table.Column<int>(type: "int", nullable: false),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousJobs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PreviousJobs_TeacherInfos_TeacherInfoID",
                        column: x => x.TeacherInfoID,
                        principalTable: "TeacherInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherLanguages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherInfoID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    PreferenceLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLanguages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TeacherLanguages_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherLanguages_TeacherInfos_TeacherInfoID",
                        column: x => x.TeacherInfoID,
                        principalTable: "TeacherInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_TeacherInfoID",
                table: "Books",
                column: "TeacherInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_SubjectID",
                table: "Certificates",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_TeacherInfoID",
                table: "Certificates",
                column: "TeacherInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_PreferedSubjects_SubjectID",
                table: "PreferedSubjects",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_PreferedSubjects_TeacherInfoID",
                table: "PreferedSubjects",
                column: "TeacherInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousJobs_TeacherInfoID",
                table: "PreviousJobs",
                column: "TeacherInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfos_DepartmentID",
                table: "TeacherInfos",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfos_GenderID",
                table: "TeacherInfos",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfos_ProfessionID",
                table: "TeacherInfos",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfos_ScientificDegreeID",
                table: "TeacherInfos",
                column: "ScientificDegreeID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfos_ScientificNameID",
                table: "TeacherInfos",
                column: "ScientificNameID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfos_WorkTimeID",
                table: "TeacherInfos",
                column: "WorkTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLanguages_LanguageID",
                table: "TeacherLanguages",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLanguages_TeacherInfoID",
                table: "TeacherLanguages",
                column: "TeacherInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_TLExcludeds_DepartmentID",
                table: "TLExcludeds",
                column: "DepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "LayoutInfos");

            migrationBuilder.DropTable(
                name: "PreferedSubjects");

            migrationBuilder.DropTable(
                name: "PreviousJobs");

            migrationBuilder.DropTable(
                name: "TeacherLanguages");

            migrationBuilder.DropTable(
                name: "TLExcludeds");

            migrationBuilder.DropTable(
                name: "TLIncludeds");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TeacherInfos");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "ScientificDegrees");

            migrationBuilder.DropTable(
                name: "ScientificNames");

            migrationBuilder.DropTable(
                name: "WorkTimes");
        }
    }
}
