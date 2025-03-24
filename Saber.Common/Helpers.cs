using System.Text.RegularExpressions;

namespace Saber.Common;

public class Helpers
{
    public static readonly Random Random = new();

    public static readonly string[] EightBallResponses =
    {
        "It is decidedly so.",
        "Reply hazy, try again.",
        "Ask again later.",
        "Better not tell you now.",
        "Don't count on it.",
        "Yes.",
        "My sources say no.",
        "Concentrate and ask again.",
        "Most likely.",
        "As I see it, yes.",
        "You may rely on it.",
        "Without a doubt.",
        "Yes - definitely.",
        "Signs point to yes.",
        "My reply is no.",
        "Cannot predict now.",
        "It is certain.",
        "Very doubtful.",
        "Outlook good.",
        "Outlook not so good."
    };

    public static readonly string[] NumStringArray =
    {
        "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
    };

    public static readonly string[] NumEmojiArray =
    {
        "1⃣", "2⃣", "3⃣", "4⃣", "5⃣", "6⃣", "7⃣", "8⃣", "9⃣", "🔟"
    };

    public static string StringToRegionalIndicators(string input)
    {
        var fullString = "";

        foreach (var word in input.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            foreach (var letter in word)
            {
                var l = letter.ToString();
                if (Regex.IsMatch(l, "[a-z]", RegexOptions.IgnoreCase))
                {
                    var rand = Random.NextDouble();
                    if (l.ToLower() == "a")
                    {
                        if (rand < 0.5)
                            fullString += ":a:";
                        else fullString += ":regional_indicator_a:";
                    }
                    else if (l.ToLower() == "b")
                    {
                        if (rand < 0.5)
                            fullString += ":b:";
                        else fullString += ":regional_indicator_b:";
                    }
                    else
                    {
                        fullString += $":regional_indicator_{l.ToLower()}:";
                    }
                }
                else if (Regex.IsMatch(l, "[0-9]"))
                {
                    var i = int.Parse(l);
                    if (int.TryParse(l, out i))
                        fullString += $":{NumStringArray[i]}:";
                }
                else
                {
                    fullString += $"{l}";
                }
            }

            fullString += "  ";
        }

        return fullString;
    }

    public static IEnumerable<int> DiceRoll(int dieSize, int diceToRoll = 1)
    {
        while (diceToRoll-- > 0)
            yield return Random.Next(1, dieSize + 1);
    }

    public static IEnumerable<string> GetUrls(string input)
    {
        var urls = new List<string>();
        var matches = Regex.Matches(input, @"(https?://[^\s]+)");
        foreach (Match match in matches) urls.Add(match.Value);
        return urls;
    }

    public static List<List<FileInfo>> ChunkFilesBySize(IEnumerable<FileInfo> files, long maxFileSize)
    {
        var fileChunks = new List<List<FileInfo>>();
        var currentChunk = new List<FileInfo>();
        long currentChunkSize = 0;

        foreach (var file in files)
        {
            var fileSize = file.Length;

            if (fileSize > maxFileSize) throw new ArgumentException("File size exceeds maxFileSize.");

            if (currentChunkSize + fileSize <= maxFileSize)
            {
                currentChunk.Add(file);
                currentChunkSize += fileSize;
            }
            else
            {
                fileChunks.Add(currentChunk);
                currentChunk = new List<FileInfo> { file };
                currentChunkSize = fileSize;
            }
        }

        if (currentChunk.Count > 0) fileChunks.Add(currentChunk);

        return fileChunks;
    }
}