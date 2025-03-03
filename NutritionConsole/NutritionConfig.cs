using System.Text.Json.Serialization;

namespace NutritionConsole;

public class NutritionConfig
{
    public string NutritionUnit { get; }
    public int ValuePerCharacter { get; }

	/*[JsonConstructor]*/
    public NutritionConfig(string nutritionUnit, int valuePerCharacter)
    {
        NutritionUnit = nutritionUnit;
        ValuePerCharacter = valuePerCharacter;
    }
}
