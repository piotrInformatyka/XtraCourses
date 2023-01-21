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
    [Migration("20230121221138_Properties as nullable")]
    partial class Propertiesasnullable
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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("XtraCourses.Application.Models.User", b =>
                {
                    b.Property<string>("Person")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImportTag")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .HasColumnType("TEXT");

                    b.Property<string>("Upn")
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
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<string>("CompletedDate")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<int?>("CompletedLessonsCount")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<string>("CourseStartedDate")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<string>("HaveNotStarted")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<string>("HaveStarted")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<bool?>("IsPassed")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(false);

                            b1.Property<string>("NotOnSchedule")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue("");

                            b1.Property<int?>("OpenedLessonsCount")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<int?>("QuizScore")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<int?>("QuizScoreTotal")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0);

                            b1.Property<int?>("TotalLessonsCount")
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
