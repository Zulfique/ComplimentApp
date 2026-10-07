using ComplimentApp;

ComplimentManager manager = new ComplimentManager();

string message = manager.GenerateCompliment();
Compliment compliment = new Compliment(message);

Console.WriteLine("Here is a random compliment for you:");
Console.WriteLine(compliment);
Console.WriteLine();

Console.Write("Would you like to save this compliment? (y/n): ");
string? saveAnswer = Console.ReadLine();
if (string.Equals(saveAnswer?.Trim(), "y", StringComparison.OrdinalIgnoreCase))
{
    manager.SaveCompliment(compliment);
    Console.WriteLine("Compliment saved to Compliments/favorite_compliments.txt");
}
else
{
    Console.WriteLine("Not saved.");
}
Console.WriteLine();

Console.Write("Would you like to view all saved compliments? (y/n): ");
string? viewAnswer = Console.ReadLine();
if (string.Equals(viewAnswer?.Trim(), "y", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine();
    Console.WriteLine("Saved compliments:");
    manager.ViewSavedCompliments();
}
Console.WriteLine();

Console.WriteLine("Press any key to exit...");
if (!Console.IsInputRedirected)
{
    Console.ReadKey(true);
}
