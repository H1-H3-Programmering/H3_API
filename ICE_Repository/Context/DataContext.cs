using ICE_Repository.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ICE_Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }
        public DbSet<UserHistory> UserHistories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<DietaryPreference> DietaryPreferences { get; set; }
        public DbSet<UserPreference> UserPreferences { get; set; }
        public DbSet<RecipeTag> RecipeTags { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.EnableSensitiveDataLogging();
        //    // Other configuration options...
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Seed Categories entities
        //    Category category1 = new Category() { CategoryId = 1, Name = "Protein" };
        //    Category category2 = new Category() { CategoryId = 2, Name = "Kulhydrat" };
        //    modelBuilder.Entity<Category>().HasData(category1);
        //    modelBuilder.Entity<Category>().HasData(category2);

        //    // Seed Countries entities
        //    Country country1 = new Country() { CountryId = 1, CountryName = "Denmark", Continent = "Europe" };
        //    Country country2 = new Country() { CountryId = 2, CountryName = "Denmark", Continent = "Europe" };
        //    modelBuilder.Entity<Country>().HasData(country1);
        //    modelBuilder.Entity<Country>().HasData(country2);

        //    // Seed DietaryPreferences entities
        //    DietaryPreference dietaryPreference1 = new DietaryPreference() { DietaryPreferenceId = 1, PreferenceId = 1 };
        //    DietaryPreference dietaryPreference2 = new DietaryPreference() { DietaryPreferenceId = 2, PreferenceId = 2 };
        //    modelBuilder.Entity<DietaryPreference>().HasData(dietaryPreference1);
        //    modelBuilder.Entity<DietaryPreference>().HasData(dietaryPreference2);

        //    // Seed Ingredients entities
        //    Ingredient ingredient1 = new Ingredient() { IngredientsId = 1, Name = "Banan", CategoryId = 1, RecipeId = 1 };
        //    Ingredient ingredient2 = new Ingredient() { IngredientsId = 2, Name = "Banan", CategoryId = 2, RecipeId = 2 };
        //    modelBuilder.Entity<Ingredient>().HasData(ingredient1);
        //    modelBuilder.Entity<Ingredient>().HasData(ingredient2);

        //    // Seed Kitchens entities
        //    Kitchen kitchen1 = new Kitchen() { KitchenId = 1, Name = "Yoyo", Continent = "North America", Region = "West", CountryId = 1, RecipeId = 1 };
        //    Kitchen kitchen2 = new Kitchen() { KitchenId = 2, Name = "Hihi", Continent = "North America", Region = "East", CountryId = 2, RecipeId = 2 };
        //    modelBuilder.Entity<Kitchen>().HasData(kitchen1);
        //    modelBuilder.Entity<Kitchen>().HasData(kitchen2);

        //    // Seed Languages entities
        //    Language language1 = new Language() { LanguageId = 1, LanguageName = "English", CountryId = 1 };
        //    Language language2 = new Language() { LanguageId = 2, LanguageName = "French", CountryId = 2 };
        //    modelBuilder.Entity<Language>().HasData(language1);
        //    modelBuilder.Entity<Language>().HasData(language2);

        //    // Seed Recipes entities
        //    Recipe recipe1 = new Recipe()
        //    {
        //        RecipeId = 1,
        //        Name = "Recipe 1",
        //        Description = "Description of Recipe 1",
        //        Origin = "Origin of Recipe 1",
        //        Instructions = "Instructions for Recipe 1",
        //        Difficulty = 1,
        //        PreperationTime = 30
        //    };
        //    Recipe recipe2 = new Recipe()
        //    {
        //        RecipeId = 2,
        //        Name = "Recipe 2",
        //        Description = "Description of Recipe 2",
        //        Origin = "Origin of Recipe 2",
        //        Instructions = "Instructions for Recipe 2",
        //        Difficulty = 2,
        //        PreperationTime = 45
        //    };
        //    modelBuilder.Entity<Recipe>().HasData(recipe1);
        //    modelBuilder.Entity<Recipe>().HasData(recipe2);

        //    // Seed RecipeIngredientJOIN entities
        //    RecipeIngredientJOIN recipeIngredientJOIN1 = new RecipeIngredientJOIN()
        //    {
        //        RecipeIngredientJOINId = 1,
        //        RecipeId = 1,
        //        IngredientsId = 1
        //    };
        //    RecipeIngredientJOIN recipeIngredientJOIN2 = new RecipeIngredientJOIN()
        //    {
        //        RecipeIngredientJOINId = 2,
        //        RecipeId = 2,
        //        IngredientsId = 2
        //    };
        //    modelBuilder.Entity<RecipeIngredientJOIN>().HasData(recipeIngredientJOIN1);
        //    modelBuilder.Entity<RecipeIngredientJOIN>().HasData(recipeIngredientJOIN2);

        //    // Seed RecipeTag entities
        //    RecipeTag recipeTag1 = new RecipeTag()
        //    {
        //        RecipeTagId = 1,
        //        RecipeId = 1, // Assuming this corresponds to an existing RecipeId
        //        Tag = "Tag1"
        //    };
        //    RecipeTag recipeTag2 = new RecipeTag()
        //    {
        //        RecipeTagId = 2,
        //        RecipeId = 2, // Assuming this corresponds to an existing RecipeId
        //        Tag = "Tag2"
        //    };
        //    modelBuilder.Entity<RecipeTag>().HasData(recipeTag1);
        //    modelBuilder.Entity<RecipeTag>().HasData(recipeTag2);

        //    // Seed Regions entities
        //    Regions region1 = new Regions()
        //    {
        //        RegionId = 1,
        //        RegionName = "Region 1",
        //        CountryId = 1 // Assuming this corresponds to an existing CountryId
        //    };
        //    Regions region2 = new Regions()
        //    {
        //        RegionId = 2,
        //        RegionName = "Region 2",
        //        CountryId = 2 // Assuming this corresponds to an existing CountryId
        //    };
        //    modelBuilder.Entity<Regions>().HasData(region1);
        //    modelBuilder.Entity<Regions>().HasData(region2);

        //    // Seed Reviews entities
        //    Review review1 = new Review()
        //    {
        //        ReviewId = 1,
        //        Rating = 5,
        //        Comment = "Great recipe!",
        //        UserId = 1, // Assuming this corresponds to an existing UserId
        //        RecipeId = 1 // Assuming this corresponds to an existing RecipeId
        //    };
        //    Review review2 = new Review()
        //    {
        //        ReviewId = 2,
        //        Rating = 4,
        //        Comment = "Nice dish!",
        //        UserId = 2, // Assuming this corresponds to an existing UserId
        //        RecipeId = 2 // Assuming this corresponds to an existing RecipeId
        //    };
        //    modelBuilder.Entity<Review>().HasData(review1);
        //    modelBuilder.Entity<Review>().HasData(review2);

        //    // Seed Users entities
        //    Users user1 = new Users()
        //    {
        //        UserId = 1,
        //        Username = "user1",
        //        Email = "user1@example.com",
        //        Password = "password1"
        //    };
        //    Users user2 = new Users()
        //    {
        //        UserId = 2,
        //        Username = "user2",
        //        Email = "user2@example.com",
        //        Password = "password2"
        //    };
        //    modelBuilder.Entity<Users>().HasData(user1);
        //    modelBuilder.Entity<Users>().HasData(user2);

        //    // Seed UserFavorite entities
        //    UserFavorite userFavorite1 = new UserFavorite() { UserFavoriteId = 1, UserId = 1 };
        //    UserFavorite userFavorite2 = new UserFavorite() { UserFavoriteId = 2, UserId = 2 };
        //    modelBuilder.Entity<UserFavorite>().HasData(userFavorite1);
        //    modelBuilder.Entity<UserFavorite>().HasData(userFavorite2);

        //    // Seed UserFavoriteRecipeJOIN entities
        //    UserFavoriteRecipeJOIN userFavoriteRecipeJOIN1 = new UserFavoriteRecipeJOIN() { UserFavoriteRecipeJOINId = 1, UserFavoriteId = 1, RecipeId = 1 };
        //    UserFavoriteRecipeJOIN userFavoriteRecipeJOIN2 = new UserFavoriteRecipeJOIN() { UserFavoriteRecipeJOINId = 2, UserFavoriteId = 2, RecipeId = 2 };
        //    modelBuilder.Entity<UserFavoriteRecipeJOIN>().HasData(userFavoriteRecipeJOIN1);
        //    modelBuilder.Entity<UserFavoriteRecipeJOIN>().HasData(userFavoriteRecipeJOIN2);

        //    // Seed UserHistory entities
        //    UserHistory userHistory1 = new UserHistory() { UserHistoryId = 1, UserId = 1, RecipeId = 1 };
        //    UserHistory userHistory2 = new UserHistory() { UserHistoryId = 2, UserId = 2, RecipeId = 2 };
        //    modelBuilder.Entity<UserHistory>().HasData(userHistory1);
        //    modelBuilder.Entity<UserHistory>().HasData(userHistory2);

        //    // Seed UserPreference entities
        //    UserPreference userPreference1 = new UserPreference() { PreferenceId = 1, PreferenceType = "Type1", PreferenceDescription = "Description1" };
        //    UserPreference userPreference2 = new UserPreference() { PreferenceId = 2, PreferenceType = "Type2", PreferenceDescription = "Description2" };
        //    modelBuilder.Entity<UserPreference>().HasData(userPreference1);
        //    modelBuilder.Entity<UserPreference>().HasData(userPreference2);

        //    // Seed Comments entities
        //    Comments comments1 = new Comments() { CommentId = 1, UserId = 1, Text = "Hello" };
        //    Comments comments2 = new Comments() { CommentId = 2, UserId = 2, Text = "Hello" };
        //    modelBuilder.Entity<Comments>().Ignore(c => c.Recipe); // Ignore Recipe navigation property
        //    modelBuilder.Entity<Comments>().Ignore(c => c.User); // Ignore User navigation property
        //    modelBuilder.Entity<Comments>().HasData(comments1);
        //    modelBuilder.Entity<Comments>().HasData(comments2);

        //    // Seed UserDietaryPreferenceJOIN entities (Junction table)
        //    UserDietaryPreferenceJOIN userDietaryPreferenceJOIN1 = new UserDietaryPreferenceJOIN() { UserDietaryPreferenceJOINId = 1, UserId = 1, DietaryPreferenceId = 1 };
        //    UserDietaryPreferenceJOIN userDietaryPreferenceJOIN2 = new UserDietaryPreferenceJOIN() { UserDietaryPreferenceJOINId = 2, UserId = 2, DietaryPreferenceId = 2 };
        //    modelBuilder.Entity<UserDietaryPreferenceJOIN>().HasData(userDietaryPreferenceJOIN1);
        //    modelBuilder.Entity<UserDietaryPreferenceJOIN>().HasData(userDietaryPreferenceJOIN2);

        //    // Configure many-to-many relationship between Category and Recipe using CategoryRecipeJOIN
        //    modelBuilder.Entity<CategoryRecipeJOIN>()
        //        .HasKey(pc => new { pc.CategoryId, pc.RecipeId });

        //    modelBuilder.Entity<CategoryRecipeJOIN>()
        //        .HasOne(pc => pc.category)
        //        .WithMany(c => c.CategoryRecipeJOINs)
        //        .HasForeignKey(pc => pc.CategoryId);

        //    modelBuilder.Entity<CategoryRecipeJOIN>()
        //        .HasOne(pc => pc.Recipe)
        //        .WithMany(r => r.CategoryRecipeJOINs)
        //        .HasForeignKey(pc => pc.RecipeId);

        //    // Configure many-to-many relationship between User and DietaryPreference using UserDietaryPreferenceJOIN
        //    modelBuilder.Entity<UserDietaryPreferenceJOIN>()
        //        .HasKey(pc => new { pc.UserId, pc.DietaryPreferenceId });

        //    modelBuilder.Entity<UserDietaryPreferenceJOIN>()
        //        .HasOne(pc => pc.User)
        //        .WithMany(u => u.UserDietaryPreferenceJOINs)
        //        .HasForeignKey(pc => pc.UserId);

        //    modelBuilder.Entity<UserDietaryPreferenceJOIN>()
        //        .HasOne(pc => pc.DietaryPreference)
        //        .WithMany(dp => dp.UserDietaryPreferenceJOINs)
        //        .HasForeignKey(pc => pc.DietaryPreferenceId);

        //    // Configure many-to-many relationship between UserFavorite and Recipe using UserFavoriteRecipeJOIN
        //    modelBuilder.Entity<UserFavoriteRecipeJOIN>()
        //        .HasKey(pc => new { pc.UserFavoriteId, pc.RecipeId });

        //    modelBuilder.Entity<UserFavoriteRecipeJOIN>()
        //        .HasOne(pc => pc.UserFavorite)
        //        .WithMany(u => u.UserFavoriteRecipeJOINs)
        //        .HasForeignKey(pc => pc.UserFavoriteId);

        //    modelBuilder.Entity<UserFavoriteRecipeJOIN>()
        //        .HasOne(pc => pc.Recipe)
        //        .WithMany(u => u.UserFavoriteRecipeJOINs)
        //        .HasForeignKey(pc => pc.RecipeId);

        //    // Configure many-to-many relationship between Recipe and Ingredient using RecipeIngredientJOIN
        //    modelBuilder.Entity<RecipeIngredientJOIN>()
        //        .HasKey(pc => new { pc.RecipeId, pc.IngredientsId });

        //    modelBuilder.Entity<RecipeIngredientJOIN>()
        //        .HasOne(pc => pc.recipes)
        //        .WithMany(u => u.RecipeIngredientJOINs)
        //        .HasForeignKey(pc => pc.RecipeId);

        //    modelBuilder.Entity<RecipeIngredientJOIN>()
        //        .HasOne(pc => pc.Ingredients)
        //        .WithMany(u => u.RecipeIngredientJOINs)
        //        .HasForeignKey(pc => pc.IngredientsId);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
