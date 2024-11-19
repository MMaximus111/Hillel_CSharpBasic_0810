namespace Lesson11;

public class CustomInt
{
    public static bool TryParse(string text, out int result)
    {
        if (int.TryParse(text, out int number))
        {
            result = number;
            return true;
        }

        result = 0;
        return false;
    }
    
    public static bool TryParse(char symbol, out int result)
    {
        if (int.TryParse(symbol.ToString(), out int number))
        {
            result = number;
            return true;
        }

        result = 0;
        return false;
    }
}