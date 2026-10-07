namespace ComplimentApp;

public class Compliment
{
    public string Message { get; set; }
    public DateTime DateSaved { get; set; }

    public Compliment(string message)
    {
        Message = message;
        DateSaved = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Message} (Saved: {DateSaved:dd MMM yyyy HH:mm})";
    }
}
