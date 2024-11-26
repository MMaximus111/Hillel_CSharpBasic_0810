namespace Lesson12.Tests;

public class MathTests
{
    [Fact]
    public void Max_MaxIsFirst_ReturnsFirst()
    {
        // Arrange
        
        const int maxNumber = 2;
        
        // Act
        int result = Math.Max(maxNumber, 1);

        // Assert
        Assert.Equal(maxNumber, result);
    }
    
    [Fact]
    public void Max_MaxIsSecond_ReturnsSecond()
    {
        // Arrange
        
        const int maxNumber = 2;
        
        // Act
        int result = Math.Max(1, maxNumber);

        // Assert
        Assert.Equal(maxNumber, result);
    }
}