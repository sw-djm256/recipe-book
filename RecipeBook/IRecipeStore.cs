namespace RecipeBook;

public interface IRecipeStore
{
    public Recipe Get(string name);
    public void Add(Recipe recipe);
}