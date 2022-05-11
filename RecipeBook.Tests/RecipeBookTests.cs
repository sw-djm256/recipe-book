using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;

namespace RecipeBook.Tests
{
    public class RecipeBookTests
    {
        private IRecipeStore _recipes;
        private IIngredientStore _ingredients;
        private RecipeBook _recipeBook;
        
        [SetUp]
        public void Setup()
        {
            _recipes = Substitute.For<IRecipeStore>();
            _ingredients = Substitute.For<IIngredientStore>();
            _recipeBook = new RecipeBook(_recipes, _ingredients);
        }

        [Test]
        public void Save_AddsTheRecipeToTheStore()
        {
            var testRecipe = new Recipe("Filet Mignon");
            _recipeBook.Save(testRecipe);
            
            _recipes.Received().Add(testRecipe);
        }

        [Test]
        public void Recall_ReturnsASavedRecipe()
        {
            var testRecipe = new Recipe("Pad Thai");
            _recipes.Get(testRecipe.Name).Returns(testRecipe);
            
            var actualRecipe = _recipeBook.Recall(testRecipe.Name);
            
            Assert.That(actualRecipe, Is.EqualTo(testRecipe));
        }
        
        [Test]
        public void Make_UsesIngredientsBasedOnTheRecipe()
        {
            var recipeName = "Ham on Rye";
            var ryeBread = new Ingredient("rye bread", 64.0);
            var ham = new Ingredient("ham", 84.0);
            _recipes.Get(recipeName).Returns(new Recipe(recipeName)
                { Ingredients = new List<Ingredient> { ryeBread, ham } });

            _recipeBook.Make(recipeName);
            
            _ingredients.Received().Use(ryeBread.Name, ryeBread.Amount);
            _ingredients.Received().Use(ham.Name, ham.Amount);
        }
    }
}