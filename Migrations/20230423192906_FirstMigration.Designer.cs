﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using movie_restful_api_csharp.Data;

#nullable disable

namespace movie_restful_api_csharp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230423192906_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("movie_restful_api_csharp.Models.GenreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tmdb_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.MovieGenreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Genre_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Movie_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Genre_Id");

                    b.HasIndex("Movie_Id");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.MovieModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.MovieRatingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Movie_Id")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Movie_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("MovieRating");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.UserGenreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Genre_Id")
                        .HasColumnType("int");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Genre_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("UserGener");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.MovieGenreModel", b =>
                {
                    b.HasOne("movie_restful_api_csharp.Models.GenreModel", "Genre")
                        .WithMany("Movie")
                        .HasForeignKey("Genre_Id");

                    b.HasOne("movie_restful_api_csharp.Models.MovieModel", "Movie")
                        .WithMany()
                        .HasForeignKey("Movie_Id");

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.MovieModel", b =>
                {
                    b.HasOne("movie_restful_api_csharp.Models.UserModel", "User")
                        .WithMany("Movie")
                        .HasForeignKey("User_Id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.MovieRatingModel", b =>
                {
                    b.HasOne("movie_restful_api_csharp.Models.MovieModel", "Movie")
                        .WithMany()
                        .HasForeignKey("Movie_Id");

                    b.HasOne("movie_restful_api_csharp.Models.UserModel", "User")
                        .WithMany("MovieRating")
                        .HasForeignKey("User_Id");

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.UserGenreModel", b =>
                {
                    b.HasOne("movie_restful_api_csharp.Models.GenreModel", "Genre")
                        .WithMany("Genre")
                        .HasForeignKey("Genre_Id");

                    b.HasOne("movie_restful_api_csharp.Models.UserModel", "User")
                        .WithMany("UserGenre")
                        .HasForeignKey("User_Id");

                    b.Navigation("Genre");

                    b.Navigation("User");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.GenreModel", b =>
                {
                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("movie_restful_api_csharp.Models.UserModel", b =>
                {
                    b.Navigation("Movie");

                    b.Navigation("MovieRating");

                    b.Navigation("UserGenre");
                });
#pragma warning restore 612, 618
        }
    }
}
