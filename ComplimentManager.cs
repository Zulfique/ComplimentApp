namespace ComplimentApp;

public class ComplimentManager
{
    private static readonly string[] Compliments =
    {
        "You have a great smile!",
        "Your positivity is contagious.",
        "You are incredibly thoughtful.",
        "You make the world a better place.",
        "Your creativity is inspiring.",
        "You are a great listener.",
        "You light up every room you walk into.",
        "Your hard work never goes unnoticed.",
        "You give the best advice.",
        "You are one of a kind!"
    };

    private static readonly Random Random = new();

    private readonly string _folderPath;
    private readonly string _filePath;

    public ComplimentManager(string folderName = "Compliments",
        string fileName = "favorite_compliments.txt")
    {
        DirectoryInfo folder = new DirectoryInfo(folderName);
        if (!folder.Exists)
        {
            folder.Create();
        }

        _folderPath = folder.FullName;
        _filePath = Path.Combine(_folderPath, fileName);
    }

    public string GenerateCompliment()
    {
        return Compliments[Random.Next(Compliments.Length)];
    }

    public void SaveCompliment(Compliment compliment)
    {
        using StreamWriter writer = new StreamWriter(_filePath, append: true);
        writer.WriteLine(compliment.ToString());
    }

    public void ViewSavedCompliments()
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine("No saved compliments yet.");
            return;
        }

        using StreamReader reader = new StreamReader(_filePath);
        string? line;
        bool any = false;
        while ((line = reader.ReadLine()) != null)
        {
            any = true;
            Console.WriteLine(line);
        }

        if (!any)
        {
            Console.WriteLine("No saved compliments yet.");
        }
    }
}
