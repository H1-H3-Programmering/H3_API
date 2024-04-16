﻿// <auto-generated />
using ICE_Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ICE_Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240416094643_test12")]
    partial class test12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ICE_Repository.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ICE_Repository.Models.Comments", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ICE_Repository.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("Continent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ICE_Repository.Models.DietaryPreference", b =>
                {
                    b.Property<int>("DietaryPreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DietaryPreferenceId"));

                    b.Property<int>("PreferenceId")
                        .HasColumnType("int");

                    b.HasKey("DietaryPreferenceId");

                    b.HasIndex("PreferenceId");

                    b.ToTable("DietaryPreferences");
                });

            modelBuilder.Entity("ICE_Repository.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientsId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientsId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("ICE_Repository.Models.Kitchen", b =>
                {
                    b.Property<int>("KitchenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitchenId"));

                    b.Property<string>("Continent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KitchenId");

                    b.HasIndex("CountryId");

                    b.ToTable("Kitchens");
                });

            modelBuilder.Entity("ICE_Repository.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.HasIndex("CountryId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ICE_Repository.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreperationTime")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("ICE_Repository.Models.RecipeTag", b =>
                {
                    b.Property<int>("RecipeTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeTagId"));

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeTagId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeTags");
                });

            modelBuilder.Entity("ICE_Repository.Models.Regions", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("ICE_Repository.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserDietaryPreferenceJOIN", b =>
                {
                    b.Property<int>("UserDietaryPreferenceJOINId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDietaryPreferenceJOINId"));

                    b.Property<int>("DietaryPreferenceId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserDietaryPreferenceJOINId");

                    b.HasIndex("DietaryPreferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDietaryPreferenceJOIN");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserFavorite", b =>
                {
                    b.Property<int>("UserFavoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserFavoriteId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserFavoriteId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFavorites");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserFavoriteRecipeJOIN", b =>
                {
                    b.Property<int>("UserFavoriteRecipeJOINId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserFavoriteRecipeJOINId"));

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("UserFavoriteId")
                        .HasColumnType("int");

                    b.HasKey("UserFavoriteRecipeJOINId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserFavoriteId");

                    b.ToTable("UserFavoriteRecipeJOIN");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserHistory", b =>
                {
                    b.Property<int>("UserHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserHistoryId"));

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserHistoryId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserHistories");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserPreference", b =>
                {
                    b.Property<int>("PreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreferenceId"));

                    b.Property<string>("PreferenceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferenceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreferenceId");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("ICE_Repository.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ICE_Repository.Models.Comments", b =>
                {
                    b.HasOne("ICE_Repository.Models.Recipe", "Recipe")
                        .WithMany("CommentId")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICE_Repository.Models.Users", "User")
                        .WithMany("CommentId")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ICE_Repository.Models.DietaryPreference", b =>
                {
                    b.HasOne("ICE_Repository.Models.UserPreference", "Preference")
                        .WithMany("DietaryPreferenceId")
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preference");
                });

            modelBuilder.Entity("ICE_Repository.Models.Kitchen", b =>
                {
                    b.HasOne("ICE_Repository.Models.Country", "Country")
                        .WithMany("Kitchen")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ICE_Repository.Models.Language", b =>
                {
                    b.HasOne("ICE_Repository.Models.Country", "Country")
                        .WithMany("Language")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ICE_Repository.Models.RecipeTag", b =>
                {
                    b.HasOne("ICE_Repository.Models.Recipe", "Recipes")
                        .WithMany("RecipeTag")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("ICE_Repository.Models.Regions", b =>
                {
                    b.HasOne("ICE_Repository.Models.Country", "Country")
                        .WithMany("Region")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ICE_Repository.Models.Review", b =>
                {
                    b.HasOne("ICE_Repository.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICE_Repository.Models.Users", "User")
                        .WithMany("ReviewId")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserDietaryPreferenceJOIN", b =>
                {
                    b.HasOne("ICE_Repository.Models.DietaryPreference", "DietaryPreference")
                        .WithMany("UserId")
                        .HasForeignKey("DietaryPreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICE_Repository.Models.Users", "User")
                        .WithMany("DietaryPreference")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietaryPreference");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserFavorite", b =>
                {
                    b.HasOne("ICE_Repository.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserFavoriteRecipeJOIN", b =>
                {
                    b.HasOne("ICE_Repository.Models.Recipe", "Recipe")
                        .WithMany("UserFavorites")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICE_Repository.Models.UserFavorite", "UserFavorite")
                        .WithMany("RecipeId")
                        .HasForeignKey("UserFavoriteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("UserFavorite");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserHistory", b =>
                {
                    b.HasOne("ICE_Repository.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICE_Repository.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ICE_Repository.Models.Country", b =>
                {
                    b.Navigation("Kitchen");

                    b.Navigation("Language");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("ICE_Repository.Models.DietaryPreference", b =>
                {
                    b.Navigation("UserId");
                });

            modelBuilder.Entity("ICE_Repository.Models.Recipe", b =>
                {
                    b.Navigation("CommentId");

                    b.Navigation("RecipeTag");

                    b.Navigation("UserFavorites");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserFavorite", b =>
                {
                    b.Navigation("RecipeId");
                });

            modelBuilder.Entity("ICE_Repository.Models.UserPreference", b =>
                {
                    b.Navigation("DietaryPreferenceId");
                });

            modelBuilder.Entity("ICE_Repository.Models.Users", b =>
                {
                    b.Navigation("CommentId");

                    b.Navigation("DietaryPreference");

                    b.Navigation("ReviewId");
                });
#pragma warning restore 612, 618
        }
    }
}
