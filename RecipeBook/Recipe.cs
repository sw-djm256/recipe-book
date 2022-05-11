namespace RecipeBook;

public class Recipe
{
    public Recipe(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public List<Instruction> Instructions { get; set; } = new List<Instruction>();
}

public class Ingredient
{
    public Ingredient(string name, double amount)
    {
        Amount = amount;
        Name = name;
    }
    public double Amount { get; set; }
    public string Name { get; set; }
}

public class Instruction
{
    public Instruction(int stepNumber, string details)
    {
        Order = stepNumber;
        Details = details;
    }
    
    public string Details { get; set; }
    public int Order { get; set; }
}