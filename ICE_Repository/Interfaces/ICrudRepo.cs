using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ICE_Repository.Interfaces
{
    public interface ICrudRepo<Crud>
    {
        Crud Create(Crud crud);
        List<Crud> GetAll();
        Crud UpdateById(int id, Crud updatedRow);
        Crud DeleteById(int id);
    }
    public interface IUserRepository : ICrudRepo<Users>{ }
    public interface IRecipeRepo : ICrudRepo<Recipe>{ }
    public interface IIngredientRepo : ICrudRepo<Ingredient> { }
    public interface IKitchenRepo : ICrudRepo<Kitchen> { }
    public interface ICategoryRepo: ICrudRepo<Category> { }
    public interface IReviewRepo: ICrudRepo<Review> { }
    public interface IUserFavoriteRepo: ICrudRepo<UserFavorite> { }
    public interface IUserHistoryRepo : ICrudRepo<UserHistory> { }
    public interface ICommentRepo : ICrudRepo<Comments> { }
    public interface ILanguageRepo : ICrudRepo<Language> { }
    public interface ICountryRepo : ICrudRepo<Country> { }
    public interface IRegionRepo : ICrudRepo<Regions> { }
    public interface IDietaryPreferenceRepo : ICrudRepo<DietaryPreference> { }
    public interface IUserPreferenceRepo : ICrudRepo<UserPreference> { }
    public interface IRecipeTagRepo : ICrudRepo<RecipeTag>
    {
        RecipeTag DeleteByRecipeId(int recipeId);
    }
}
