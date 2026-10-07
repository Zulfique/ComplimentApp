# ComplimentApp

C# console application demonstrating file I/O with `DirectoryInfo`, `StreamWriter` and `StreamReader`.

## Classes

- **Compliment** — `Message` and `DateSaved` properties; the constructor sets `DateSaved` to the current date/time; `ToString()` returns the compliment and its saved date.
- **ComplimentManager** — checks for (and creates) a `Compliments` folder with `DirectoryInfo`; `GenerateCompliment()` returns a random compliment from a predefined list; `SaveCompliment()` appends to `Compliments/favorite_compliments.txt` with `StreamWriter`; `ViewSavedCompliments()` reads the file with `StreamReader`.

## Sample run

```
Here is a random compliment for you:
You give the best advice. (Saved: 07 Oct 2026 14:39)

Would you like to save this compliment? (y/n): y
Compliment saved to Compliments/favorite_compliments.txt

Would you like to view all saved compliments? (y/n): y

Saved compliments:
You give the best advice. (Saved: 07 Oct 2026 14:39)

Press any key to exit...
```

## Run

```bash
dotnet run
```
