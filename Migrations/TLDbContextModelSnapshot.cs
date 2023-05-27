﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeachingLoadInfoSystem.AppDbContext;

#nullable disable

namespace TeachingLoadInfoSystem.Migrations
{
    [DbContext(typeof(TLDbContext))]
    partial class TLDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTextBook")
                        .HasColumnType("bit");

                    b.Property<int>("TeacherInfoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TeacherInfoID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Certificate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CertificateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLocal")
                        .HasColumnType("bit");

                    b.Property<string>("ReceivedCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherInfoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID");

                    b.HasIndex("TeacherInfoID");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DepartmentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.EducationPlan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AuditoriumHours")
                        .HasColumnType("int");

                    b.Property<int>("CreditCount")
                        .HasColumnType("int");

                    b.Property<int>("LaboratoryHours")
                        .HasColumnType("int");

                    b.Property<int>("LectureHours")
                        .HasColumnType("int");

                    b.Property<int>("OutsideAuditoriumHours")
                        .HasColumnType("int");

                    b.Property<string>("Semestr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeminarHours")
                        .HasColumnType("int");

                    b.Property<string>("SpecialityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<int>("TotalHours")
                        .HasColumnType("int");

                    b.Property<int>("WeeklyCourseLoad")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID");

                    b.ToTable("EducationPlans");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Gender", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("GenderCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Language", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.LayoutInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FormName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GridName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stream")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("LayoutInfos");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.PreferedSubject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherInfoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID");

                    b.HasIndex("TeacherInfoID");

                    b.ToTable("PreferedSubjects");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.PreviousJob", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherInfoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TeacherInfoID");

                    b.ToTable("PreviousJobs");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Profession", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.ScientificDegree", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DegreeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DegreeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ScientificDegrees");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.ScientificName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ScientificNames");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TLExcluded", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("Doctorate")
                        .HasColumnType("int");

                    b.Property<int>("EPedTETedTTKITA")
                        .HasColumnType("int");

                    b.Property<int>("ExamFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("ExamSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("FinalResult")
                        .HasColumnType("int");

                    b.Property<int>("FirstSemSum")
                        .HasColumnType("int");

                    b.Property<int>("LaboratoryFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("LaboratorySecondSem")
                        .HasColumnType("int");

                    b.Property<int>("LectureFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("LectureSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("MasterThesis")
                        .HasColumnType("int");

                    b.Property<int>("PrLeader")
                        .HasColumnType("int");

                    b.Property<int>("Practise")
                        .HasColumnType("int");

                    b.Property<int>("RecommendationFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("RecommendationSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("SecondSemSum")
                        .HasColumnType("int");

                    b.Property<int>("Thesis")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("TLExcludeds");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TLIncluded", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Doctorate")
                        .HasColumnType("int");

                    b.Property<int>("EPedTETedTTKITA")
                        .HasColumnType("int");

                    b.Property<int>("ExamFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("ExamSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseSecondSem")
                        .HasColumnType("int");

                    b.Property<string>("Faculty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FinalResult")
                        .HasColumnType("int");

                    b.Property<int>("FirstSemSum")
                        .HasColumnType("int");

                    b.Property<int>("LaboratoryFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("LaboratorySecondSem")
                        .HasColumnType("int");

                    b.Property<int>("LectureFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("LectureSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("MasterThesis")
                        .HasColumnType("int");

                    b.Property<int>("PrLeader")
                        .HasColumnType("int");

                    b.Property<int>("Practise")
                        .HasColumnType("int");

                    b.Property<int>("RecommendationFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("RecommendationSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("SecondSemSum")
                        .HasColumnType("int");

                    b.Property<int>("Thesis")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TLIncludeds");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeacherInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessionID")
                        .HasColumnType("int");

                    b.Property<int>("ScientificDegreeID")
                        .HasColumnType("int");

                    b.Property<int>("ScientificNameID")
                        .HasColumnType("int");

                    b.Property<string>("TeacherCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkTimeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("GenderID");

                    b.HasIndex("ProfessionID");

                    b.HasIndex("ScientificDegreeID");

                    b.HasIndex("ScientificNameID");

                    b.HasIndex("WorkTimeID");

                    b.ToTable("TeacherInfos");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeacherLanguage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("LanguageID")
                        .HasColumnType("int");

                    b.Property<int>("PreferenceLevel")
                        .HasColumnType("int");

                    b.Property<int>("TeacherInfoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("TeacherInfoID");

                    b.ToTable("TeacherLanguages");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeachingLoad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("SemesterTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherInfoID")
                        .HasColumnType("int");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TeachingLoads");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeachingLoadSubject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Doctorate")
                        .HasColumnType("int");

                    b.Property<int>("EPedTETedTTKITA")
                        .HasColumnType("int");

                    b.Property<int>("ExamFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("ExamSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("FinalResult")
                        .HasColumnType("int");

                    b.Property<int>("FirstSemSum")
                        .HasColumnType("int");

                    b.Property<int>("LaboratoryFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("LaboratorySecondSem")
                        .HasColumnType("int");

                    b.Property<int>("LectureFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("LectureSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("MasterThesis")
                        .HasColumnType("int");

                    b.Property<int>("PrLeader")
                        .HasColumnType("int");

                    b.Property<int>("Practise")
                        .HasColumnType("int");

                    b.Property<int>("RecommendationFirstSem")
                        .HasColumnType("int");

                    b.Property<int>("RecommendationSecondSem")
                        .HasColumnType("int");

                    b.Property<int>("SecondSemSum")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<int>("TeachingLoadID")
                        .HasColumnType("int");

                    b.Property<int>("Thesis")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID");

                    b.HasIndex("TeachingLoadID");

                    b.ToTable("TeachingLoadSubjects");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.WorkTime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("WorkTimeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WorkTimeFactor")
                        .HasColumnType("float");

                    b.Property<string>("WorkTimeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("WorkTimes");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Book", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.TeacherInfo", null)
                        .WithMany("Books")
                        .HasForeignKey("TeacherInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Certificate", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.TeacherInfo", null)
                        .WithMany("Certificates")
                        .HasForeignKey("TeacherInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.EducationPlan", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.Subject", "Subjects")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.PreferedSubject", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.TeacherInfo", null)
                        .WithMany("PreferedSubjects")
                        .HasForeignKey("TeacherInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.PreviousJob", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.TeacherInfo", null)
                        .WithMany("PreviousJobs")
                        .HasForeignKey("TeacherInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TLExcluded", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeacherInfo", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.ScientificDegree", "ScientificDegree")
                        .WithMany()
                        .HasForeignKey("ScientificDegreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.ScientificName", "ScientificName")
                        .WithMany()
                        .HasForeignKey("ScientificNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.WorkTime", "WorkTime")
                        .WithMany()
                        .HasForeignKey("WorkTimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Gender");

                    b.Navigation("Profession");

                    b.Navigation("ScientificDegree");

                    b.Navigation("ScientificName");

                    b.Navigation("WorkTime");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeacherLanguage", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.TeacherInfo", null)
                        .WithMany("TeacherLanguages")
                        .HasForeignKey("TeacherInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeachingLoadSubject", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.Subject", "Subjects")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeachingLoadInfoSystem.Models.TeachingLoad", null)
                        .WithMany("TeachingLoadSubjects")
                        .HasForeignKey("TeachingLoadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeacherInfo", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Certificates");

                    b.Navigation("PreferedSubjects");

                    b.Navigation("PreviousJobs");

                    b.Navigation("TeacherLanguages");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeachingLoad", b =>
                {
                    b.Navigation("TeachingLoadSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
