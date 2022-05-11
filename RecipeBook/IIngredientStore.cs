namespace RecipeBook;

public interface IIngredientStore
{
    public void Get(string name);
    public void Use(string name, double amount);
}