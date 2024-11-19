using System.Text;

namespace Lesson11;

public static class StringExtensions
{
    internal static string HillelSubstring(this string text, int startIndex, int length = default)
    {
        StringBuilder sb = new StringBuilder();
        
        int currentLength = 0;
        
        for (int i = 0; i < text.Length; i++)
        {
            if (i < startIndex)
            {
                continue;
            }

            sb.Append(text[i]);
            currentLength++;
            
            if (length != 0 && currentLength == length)
            {
                break;
            }
        }

        return sb.ToString();
    }

    public static (int LettersCount, int NumbersCount, int SpecialCharsCount) CalculateSymbols(this string text)
    {
        int lettersCount = 0;
        int numbersCount = 0;
        int specialCharsCount = 0;
        
        foreach (char symbol in text)
        {
            if (symbol == ' ')
            {
                continue;
            }
            
            if (char.IsLetter(symbol))
            {
                lettersCount++;
            }
            else if (char.IsDigit(symbol))
            {
                numbersCount++;
            }
            else
            {
                specialCharsCount++;
            }
        }

        return (lettersCount, numbersCount, specialCharsCount);
    }
    
    public static SymbolsStatistics CalculateSymbolsWithClassResult(this string text)
    {
        int lettersCount = 0;
        int numbersCount = 0;
        int specialCharsCount = 0;
        
        foreach (char symbol in text)
        {
            if (symbol == ' ')
            {
                continue;
            }
            
            if (char.IsLetter(symbol))
            {
                lettersCount++;
            }
            else if (char.IsDigit(symbol))
            {
                numbersCount++;
            }
            else
            {
                specialCharsCount++;
            }
        }

        return new SymbolsStatistics
        {
            LettersCount = lettersCount,
            NumbersCount = numbersCount,
            SpecialCharsCount = specialCharsCount
        };
    }
}