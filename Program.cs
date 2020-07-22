using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"[a-z]";
        string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....2a. Find all of the occurrences of the letter ‘d’ or  ‘e’‘REGEX [d-e]  2b. Find all of the occurrences of the letter ‘d’ or’ e’, followed by another ‘d’REGEX [d-e][*d]2c. Find all of the occurrences of the letter ‘a’, followed by any letter, then the letter ‘a’ again REGEX [a][a-z][a]2d. Find all of the words that start with the letter “p”REGEX [ ][p][a-z]*   2e. Find all of the words that end with the letter eREGEX [a-z]*[e][ ]2f. Find all of the capital lettersREGEX [A-Z]";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}