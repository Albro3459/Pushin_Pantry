using Recipe_Proj.DTOs;
using System.Threading.Tasks;

namespace Recipe_Proj.Services;

public interface IRestrictionService
{
    Task<List<RestrictionDTO>> GetAllRestrictions();
    
    Task<List<RestrictionDTO>> GetAllRestrictionsByRecipe(int recipeID);

    Task<RestrictionDTO> GetRestrictionById(int restrictionID);

    Task<List<RestrictionDTO>> GetAllActiveByRecipes(string searchKeywords);

    Task<List<RestrictionDTO>> GetAllActiveByIngredients(List<int> selectedIngredients);

}