﻿// <auto-generated />
using System;
using BlogApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogApp.Migrations
{
    [DbContext(typeof(MyBlogContext))]
    partial class MyBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogApp.DAL.Entities.Footer", b =>
                {
                    b.Property<int>("FooterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FooterId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FooterId");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("BlogApp.DAL.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogApp.DAL.Entities.PostDetail", b =>
                {
                    b.Property<int>("PostDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostDetailId"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyWord2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyWord3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyWord4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostDetailId");

                    b.HasIndex("PostId");

                    b.ToTable("PostDetails");
                });

            modelBuilder.Entity("BlogApp.DAL.Entities.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TitleId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TitleId");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("BlogApp.DAL.Entities.PostDetail", b =>
                {
                    b.HasOne("BlogApp.DAL.Entities.Post", "Post")
                        .WithMany("PostDetails")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("BlogApp.DAL.Entities.Post", b =>
                {
                    b.Navigation("PostDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
