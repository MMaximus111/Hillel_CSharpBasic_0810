namespace Lesson12;

public static class CurrencyConverter
{
    public static decimal ConvertToUsd(decimal amount, decimal currencyRate)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than or equal to zero.");
        }
        
        return amount * currencyRate;
    }
}