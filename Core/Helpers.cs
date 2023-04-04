using Discord;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;


namespace SaberBot.Core
{
    public class Helpers
    {
        public static Random Random = new Random();

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

        public static readonly string[] NumStringArray = {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
        };

        public static readonly string[] NumEmojiArray = {
            "1⃣", "2⃣", "3⃣", "4⃣", "5⃣", "6⃣", "7⃣", "8⃣", "9⃣", "🔟"
        };

        public static IEnumerable<int> DiceRoll(int dieSize, int diceToRoll = 1)
        {
            while (diceToRoll-- > 0)
                yield return Random.Next(1, dieSize + 1);
        }
    }
}
