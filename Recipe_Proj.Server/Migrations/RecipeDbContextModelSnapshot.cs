﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipe_Proj.Server.Database;

#nullable disable

namespace Recipe_Proj.Server.Migrations
{
    [DbContext(typeof(RecipeDbContext))]
    partial class RecipeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Recipe_Proj.Server.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("IngredientID");

                    b.ToTable("ingredient", (string)null);
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Calories")
                        .HasColumnType("REAL");

                    b.Property<double>("CholesterolMG")
                        .HasColumnType("REAL");

                    b.Property<double>("CookTime")
                        .HasColumnType("REAL");

                    b.Property<double>("Fiber")
                        .HasColumnType("REAL");

                    b.Property<double>("Protein")
                        .HasColumnType("REAL");

                    b.Property<string>("RecipeInstructions")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<double>("SaturatedFat")
                        .HasColumnType("REAL");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<double>("SodiumMG")
                        .HasColumnType("REAL");

                    b.Property<double>("Sugars")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalCarbs")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalFat")
                        .HasColumnType("REAL");

                    b.Property<double>("TransFat")
                        .HasColumnType("REAL");

                    b.HasKey("RecipeID");

                    b.ToTable("recipe", (string)null);
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeFavorite", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserID", "RecipeID");

                    b.HasIndex("RecipeID");

                    b.ToTable("recipe_Favorite", (string)null);
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecipeID", "IngredientID");

                    b.HasIndex("IngredientID");

                    b.ToTable("recipe_ingredient", (string)null);
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeRestriction", b =>
                {
                    b.Property<int>("RecipeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RestrictionID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecipeID", "RestrictionID");

                    b.HasIndex("RestrictionID");

                    b.ToTable("recipe_restriction", (string)null);
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("recipeUser", (string)null);
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.Restriction", b =>
                {
                    b.Property<int>("RestrictionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RestrictionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("RestrictionID");

                    b.ToTable("restriction", (string)null);
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeFavorite", b =>
                {
                    b.HasOne("Recipe_Proj.Server.Models.Recipe", "Recipe")
                        .WithMany("FavoritedBy")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipe_Proj.Server.Models.RecipeUser", "RecipeUser")
                        .WithMany("FavoriteRecipes")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("RecipeUser");
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeIngredient", b =>
                {
                    b.HasOne("Recipe_Proj.Server.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipe_Proj.Server.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeRestriction", b =>
                {
                    b.HasOne("Recipe_Proj.Server.Models.Recipe", "Recipe")
                        .WithMany("RecipeRestrictions")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipe_Proj.Server.Models.Restriction", "Restriction")
                        .WithMany("RecipeRestrictions")
                        .HasForeignKey("RestrictionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Restriction");
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.Recipe", b =>
                {
                    b.Navigation("FavoritedBy");

                    b.Navigation("RecipeIngredients");

                    b.Navigation("RecipeRestrictions");
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.RecipeUser", b =>
                {
                    b.Navigation("FavoriteRecipes");
                });

            modelBuilder.Entity("Recipe_Proj.Server.Models.Restriction", b =>
                {
                    b.Navigation("RecipeRestrictions");
                });
#pragma warning restore 612, 618
        }
    }
}
