﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XtraCourses.Infrastructure.Persistence;

#nullable disable

namespace XtraCourses.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230121194722_CustomOrganiserName as nullable")]
    partial class CustomOrganiserNameasnullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("XtraCourses.Application.Models.Course", b =>
                {
                    b.Property<Guid>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("XtraCourses.Application.Models.Project", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("XtraCourses.Application.Models.User", b =>
                {
                    b.Property<string>("Person")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImportTag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Upn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Person");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("XtraCourses.Application.Models.Project", b =>
                {
                    b.OwnsOne("XtraCourses.Application.ValueObject.ProjectDetails", "ProjectDetails", b1 =>
                        {
                            b1.Property<Guid>("ProjectId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("CertificateTitle")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<string>("CompletedDate")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<int>("CompletedLessonsCount")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<string>("CourseStartedDate")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<string>("HaveNotStarted")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<string>("HaveStarted")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<bool>("IsPassed")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(false);

                            b1.Property<string>("NotOnSchedule")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<int>("OpenedLessonsCount")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<int>("QuizScore")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<int>("QuizScoreTotal")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<int>("TotalLessonsCount")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.HasKey("ProjectId");

                            b1.ToTable("Projects");

                            b1.WithOwner()
                                .HasForeignKey("ProjectId");
                        });

                    b.Navigation("ProjectDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
