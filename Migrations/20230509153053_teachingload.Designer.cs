﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeachingLoadInfoSystem.AppDbContext;

#nullable disable

namespace TeachingLoadInfoSystem.Migrations
{
    [DbContext(typeof(TLDbContext))]
    [Migration("20230509153053_teachingload")]
    partial class teachingload
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("TeacherInfoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TeacherInfoID");

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

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("SubjectCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Subjects");
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

                    b.Property<int>("ScientificDegreeID")
                        .HasColumnType("int");

                    b.Property<int>("ScientificNameID")
                        .HasColumnType("int");

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

                    b.HasIndex("ScientificDegreeID");

                    b.HasIndex("ScientificNameID");

                    b.HasIndex("WorkTimeID");

                    b.ToTable("TeacherInfos");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.WorkTime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("WorkTimeCode")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.Language", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.TeacherInfo", null)
                        .WithMany("Languages")
                        .HasForeignKey("TeacherInfoID");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.PreviousJob", b =>
                {
                    b.HasOne("TeachingLoadInfoSystem.Models.TeacherInfo", null)
                        .WithMany("PreviousJobs")
                        .HasForeignKey("TeacherInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

                    b.Navigation("ScientificDegree");

                    b.Navigation("ScientificName");

                    b.Navigation("WorkTime");
                });

            modelBuilder.Entity("TeachingLoadInfoSystem.Models.TeacherInfo", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Certificates");

                    b.Navigation("Languages");

                    b.Navigation("PreviousJobs");
                });
#pragma warning restore 612, 618
        }
    }
}