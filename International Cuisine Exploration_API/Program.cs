using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ICE_Repository.Interfaces;
using ICE_Repository.Repositories;
using ICE_Repository.Context;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string conStr = @"Data Source=desktop-45208ai;Database=ICE_API_Database;User ID = sa; Password = Passw0rd;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
//Data Source = SKAB3 - PC8; Initial Catalog = ICE_API_Database; User ID = sa; Password = ***********; Trust Server Certificate=True
builder.Services.AddDbContext<DataContext>(obj => obj.UseSqlServer(conStr));

// DI
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<ICommentRepo, CommentRepo>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<IDietaryPreferenceRepo, DietaryPreferenceRepo>();
builder.Services.AddScoped<IIngredientRepo, IngredientRepository>();
builder.Services.AddScoped<IKitchenRepo, KitchenRepo>();
builder.Services.AddScoped<ILanguageRepo, LanguageRepo>();
builder.Services.AddScoped<IRecipeRepo, RecipeRepo>();
builder.Services.AddScoped<IRecipeTagRepo, RecipeTagRepo>();
builder.Services.AddScoped<IRegionRepo, RegionRepo>();
builder.Services.AddScoped<IReviewRepo, ReviewRepo>();
builder.Services.AddScoped<IUserFavoriteRepo, UserFavoriteRepo>();
builder.Services.AddScoped<IUserHistoryRepo, UserHistoryRepo>();
builder.Services.AddScoped<IUserPreferenceRepo, UserPreferenceRepo>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

///Cross Thread problems
builder.Services.AddCors(options =>
{
    options.AddPolicy("coffee",
                          policy =>
                          {
                              policy.AllowAnyOrigin()
                                    .AllowAnyHeader()
                                    .AllowAnyMethod();
                          });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("coffee");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
