namespace RecipeBook
{
    public class RecipeBook
    {
        private readonly IRecipeStore _recipes;
        private readonly IIngredientStore _ingredients;
        
        public RecipeBook(IRecipeStore recipeStore, IIngredientStore ingredientStore)
        {
            _recipes = recipeStore;
            _ingredients = ingredientStore;
        }

        public void Make(string name)
        {
            // get the recipe
            var recipe = _recipes.Get(name);
            
            // use ingredients
            foreach (var recipeIngredient in recipe.Ingredients)
            {
                _ingredients.Use(recipeIngredient.Name, recipeIngredient.Amount);
            }
        }
        public Recipe Recall(string name)
        {
            return _recipes.Get(name);
        }

        public void Save(Recipe recipe)
        {
            _recipes.Add(recipe);
        }
    }
}