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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Category category1 = new Category(){CategoryId = 1,Name = "Protein"};
        //    Category category2 = new Category(){CategoryId = 2,Name = "Kulhydrat"};
        //    modelBuilder.Entity<Category>().HasData(category1);
        //    modelBuilder.Entity<Category>().HasData(category2);

        //    Comments comments1 = new Comments() {CommentId = 1,UserId=1,RecipeId=1,Text="Hello"};
        //    Comments comments2 = new Comments() {CommentId = 2,UserId=2,RecipeId=2,Text="Hello"};
        //    modelBuilder.Entity<Comments>().HasData(comments1);
        //    modelBuilder.Entity<Comments>().HasData(comments2);

        //    Country country1 = new Country() {CountryId=1,CountryName="Denmark",Continent="Europe" };


        //    //Remember Conjoined classes to be included here.
        //}

            ////base.OnModelCreating(modelBuilder);
    }
    }
