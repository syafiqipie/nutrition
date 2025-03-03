using System.Text.Json;

namespace NutritionConsole;

public class Program
{
    static int Main(string[] args)
    {
		string json;
		try
		{
			json = File.ReadAllText("nutrition-config.json");
		}
		catch(FileNotFoundException)
		{
			Console.WriteLine("Config file not found");
			return 1;
		}

        var config = JsonSerializer.Deserialize<NutritionConfig>(json);
        if (config is null)
		{
			Console.WriteLine("Invalid config");
			return 1;
		}

		if (args.Count() == 0)
		{
			Console.WriteLine("Invalid input");
			return 1;
		}
        var food = args[0];
        
        var nonWhiteSpaceCount = food.Count(c => c != ' ');
        var value = nonWhiteSpaceCount * config.ValuePerCharacter;
        var unit = config.NutritionUnit;
        var message = $"The nutritional value of this food is {value} {unit}.";
        Console.WriteLine(message);
		return 0;
    }
}
