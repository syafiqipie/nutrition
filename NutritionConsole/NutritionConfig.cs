namespace NutritionConsole;

public class NutritionConfig(string nutritionUnit, int valuePerCharacter)
{
    public string NutritionUnit { get; } = nutritionUnit;
    public int ValuePerCharacter { get; } = valuePerCharacter;
}
