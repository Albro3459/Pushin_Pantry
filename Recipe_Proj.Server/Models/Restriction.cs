using System.ComponentModel.DataAnnotations;

namespace Recipe_Proj.Server.Models;

public class Restriction
{
    [Key]
    public int RestrictionID { get; set; }

    [Required]
    [StringLength(255)]
    public string RestrictionName { get; set; }

    // Navigation property
    public ICollection<RecipeRestriction> RecipeRestrictions { get; set; } = new List<RecipeRestriction>();

}