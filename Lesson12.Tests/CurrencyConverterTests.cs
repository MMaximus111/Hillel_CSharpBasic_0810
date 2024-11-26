namespace Lesson12.Tests;

public class CurrencyConverterTests
{
    [Fact]
    public void ConvertToUsd_MustConvertCorrect_WhenValidAmountAndCurrencyRateProvided()
    {
        // AAA (Arrange, Act, Assert) Pattern
        
        // Arrange

        const decimal amount = 100;
        const decimal currencyRate = 1.2m;
        
        // Act
        
        decimal result = CurrencyConverter.ConvertToUsd(amount, currencyRate);
        
        // Assert

        Assert.True(result == amount * currencyRate);
    }
    
    [Fact]
    public void ConvertToUsd_MustThrowArgumentOutOfRangeException_WhenAmountIsLessThanZero()
    {
        // Arrange

        const decimal amount = -100;
        const decimal currencyRate = 1.2m;
        
        // Act & Assert

        Assert.Throws<ArgumentOutOfRangeException>(() => CurrencyConverter.ConvertToUsd(amount, currencyRate));
    }
}