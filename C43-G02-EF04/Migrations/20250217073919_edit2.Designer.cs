﻿// <auto-generated />
using System;
using C43_G02_EF04.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C43_G02_EF04.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20250217073919_edit2")]
    partial class edit2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Department", b =>
                {
                    b.Property<int?>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("DepartmentId"));

                    b.Property<int?>("MangId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("MangId")
                        .IsUnique()
                        .HasFilter("[MangId] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentDeptId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentDeptId");

                    b.ToTable("Employees");

                    b.HasDiscriminator().HasValue("Employee");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Stud_Course", b =>
                {
                    b.Property<int>("stud_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<float>("Grade")
                        .HasColumnType("real");

                    b.HasKey("stud_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("Stud_Course");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Studient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Studients");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.FullTimeEmployee", b =>
                {
                    b.HasBaseType("C43_G02_EF04.Data.Models.Employee");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("FullTimeEmployee");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.PartTimeEmployee", b =>
                {
                    b.HasBaseType("C43_G02_EF04.Data.Models.Employee");

                    b.Property<int?>("CountOfHours")
                        .HasColumnType("int");

                    b.Property<decimal?>("HourRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasDiscriminator().HasValue("PartTimeEmployee");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Department", b =>
                {
                    b.HasOne("C43_G02_EF04.Data.Models.Employee", "Manger")
                        .WithOne("MangeDapartment")
                        .HasForeignKey("C43_G02_EF04.Data.Models.Department", "MangId");

                    b.Navigation("Manger");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Employee", b =>
                {
                    b.HasOne("C43_G02_EF04.Data.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentDeptId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Stud_Course", b =>
                {
                    b.HasOne("C43_G02_EF04.Data.Models.Course", "Course")
                        .WithMany("Stud_Course")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C43_G02_EF04.Data.Models.Studient", "Student")
                        .WithMany("Stud_Course")
                        .HasForeignKey("stud_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Course", b =>
                {
                    b.Navigation("Stud_Course");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Employee", b =>
                {
                    b.Navigation("MangeDapartment");
                });

            modelBuilder.Entity("C43_G02_EF04.Data.Models.Studient", b =>
                {
                    b.Navigation("Stud_Course");
                });
#pragma warning restore 612, 618
        }
    }
}
