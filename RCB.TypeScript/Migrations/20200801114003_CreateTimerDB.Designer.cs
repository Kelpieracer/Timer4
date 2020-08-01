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
    [Migration("20200801114003_CreateTimerDB")]
    partial class CreateTimerDB
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

                    b.Property<DateTime>("Billed")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Paid")
                        .HasColumnType("datetime2");

                    b.HasKey("BillId");

                    b.HasIndex("CustomerID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Rate", b =>
                {
                    b.Property<int>("RateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ended")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProjectID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Started")
                        .HasColumnType("datetime2");

                    b.HasKey("RateID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Topic", b =>
                {
                    b.Property<int>("TopicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.WorkItem", b =>
                {
                    b.Property<int>("WorkItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ended")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int?>("RateID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Started")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TopicsTopicID")
                        .HasColumnType("int");

                    b.HasKey("WorkItemID");

                    b.HasIndex("BillId");

                    b.HasIndex("ProjectID");

                    b.HasIndex("RateID");

                    b.HasIndex("TopicsTopicID");

                    b.ToTable("WorkItems");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Bill", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Project", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Customer", null)
                        .WithMany("Projects")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RCB.TypeScript.Models.Rate", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Customer", null)
                        .WithMany("Rates")
                        .HasForeignKey("CustomerID");

                    b.HasOne("RCB.TypeScript.Models.Project", null)
                        .WithMany("Rates")
                        .HasForeignKey("ProjectID");
                });

            modelBuilder.Entity("RCB.TypeScript.Models.WorkItem", b =>
                {
                    b.HasOne("RCB.TypeScript.Models.Bill", null)
                        .WithMany("WorkItems")
                        .HasForeignKey("BillId");

                    b.HasOne("RCB.TypeScript.Models.Project", null)
                        .WithMany("WorkItems")
                        .HasForeignKey("ProjectID");

                    b.HasOne("RCB.TypeScript.Models.Rate", "Rate")
                        .WithMany()
                        .HasForeignKey("RateID");

                    b.HasOne("RCB.TypeScript.Models.Topic", "Topics")
                        .WithMany()
                        .HasForeignKey("TopicsTopicID");
                });
#pragma warning restore 612, 618
        }
    }
}
