﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApp.WebAPI.Contexts;

#nullable disable

namespace TodoApp.WebAPI.Migrations
{
    [DbContext(typeof(TodoEFContext))]
    [Migration("20240129043833_AddIdentityToIds")]
    partial class AddIdentityToIds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TagTodoItem", b =>
                {
                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.Property<int>("ToDoItemsId")
                        .HasColumnType("int");

                    b.HasKey("TagsId", "ToDoItemsId");

                    b.HasIndex("ToDoItemsId");

                    b.ToTable("TagTodoItem");
                });

            modelBuilder.Entity("TodoApp.Shared.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0)
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("Relational:JsonPropertyName", "title");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("TodoApp.Shared.Models.TodoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0)
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasAnnotation("Relational:JsonPropertyName", "content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasAnnotation("Relational:JsonPropertyName", "title");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasAnnotation("Relational:JsonPropertyName", "updateDate");

                    b.HasKey("Id");

                    b.ToTable("ToDoItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "Physic assignment",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9780)
                        },
                        new
                        {
                            Id = 2,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "Microprocessor final lab test",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9810)
                        },
                        new
                        {
                            Id = 3,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "Digital Electronics lab",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9810)
                        },
                        new
                        {
                            Id = 4,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "Microprocessor final lab test",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820)
                        },
                        new
                        {
                            Id = 5,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "10 Home work pending",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820)
                        },
                        new
                        {
                            Id = 6,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "Chemistry assignment",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820)
                        },
                        new
                        {
                            Id = 7,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "Discrete Math notes",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820)
                        },
                        new
                        {
                            Id = 8,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            Title = "Physic assignment",
                            UpdateDate = new DateTime(2024, 1, 28, 22, 38, 33, 95, DateTimeKind.Local).AddTicks(9820)
                        });
                });

            modelBuilder.Entity("TagTodoItem", b =>
                {
                    b.HasOne("TodoApp.Shared.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoApp.Shared.Models.TodoItem", null)
                        .WithMany()
                        .HasForeignKey("ToDoItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
