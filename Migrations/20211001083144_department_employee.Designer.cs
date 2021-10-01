﻿// <auto-generated />
using System;
using Angularjs_Relational_Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Angularjs_Relational_Database.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20211001083144_department_employee")]
    partial class department_employee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Angularjs_Relational_Database.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Angularjs_Relational_Database.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("date");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Angularjs_Relational_Database.Models.Employee", b =>
                {
                    b.HasOne("Angularjs_Relational_Database.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}