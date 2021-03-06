﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RCB.TypeScript.Models;

namespace RCB.TypeScript.Migrations
{
    [DbContext(typeof(TimerDbContext))]
    [Migration("20200801174426_AddedUser")]
    partial class AddedUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RCB.TypeScript.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Billed")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Paid")
                        .HasColumnType("datetime2");

                    b.HasKey("BillId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ManagerUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CustomerId");

                    b.HasIndex("ManagerUserId");

                    b.HasIndex("Name");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProjectId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ManagerUserId");

                    b.HasIndex("Name");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Rate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ended")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Started")
                        .HasColumnType("datetime2");

                    b.HasKey("RateId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Name");

                    b.HasIndex("ProjectId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ManagerUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TopicId");

                    b.HasIndex("ManagerUserId");

                    b.HasIndex("Name");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("ProjectId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.WorkItem", b =>
                {
                    b.Property<int>("WorkItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ended")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("RateId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Started")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TopicsTopicId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkerUserId")
                        .HasColumnType("int");

                    b.HasKey("WorkItemId");

                    b.HasIndex("BillId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("RateId");

                    b.HasIndex("Started");

                    b.HasIndex("TopicsTopicId");

                    b.HasIndex("WorkerUserId");

                    b.ToTable("WorkItems");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Bill", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Customer", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.User", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerUserId");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Project", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Customer", "Customer")
                        .WithMany("Projects")
                        .HasForeignKey("CustomerId");

                    b.HasOne("RCB.TypeScript.Models.User", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerUserId");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Rate", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Customer", null)
                        .WithMany("Rates")
                        .HasForeignKey("CustomerId");

                    b.HasOne("RCB.TypeScript.Models.Project", null)
                        .WithMany("Rates")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Topic", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.User", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerUserId");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.User", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Project", null)
                        .WithMany("Members")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.WorkItem", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Bill", null)
                        .WithMany("WorkItems")
                        .HasForeignKey("BillId");

                    b.HasOne("RCB.TypeScript.Models.Project", "Project")
                        .WithMany("WorkItems")
                        .HasForeignKey("ProjectId");

                    b.HasOne("RCB.TypeScript.Models.Rate", "Rate")
                        .WithMany()
                        .HasForeignKey("RateId");

                    b.HasOne("RCB.TypeScript.Models.Topic", "Topics")
                        .WithMany()
                        .HasForeignKey("TopicsTopicId");

                    b.HasOne("RCB.TypeScript.Models.User", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
