using System;
using System.Linq;
using Xunit;

namespace Calculator;

class Statistics
{
    public static double CalculateMedian(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array must not be null or empty");

        int[] sortedNumbers = (int[])numbers.Clone();
        Array.Sort(sortedNumbers);

        int size = sortedNumbers.Length;
        int mid = size / 2;

        if (size % 2 == 0)
        {
            return (sortedNumbers[mid - 1] + sortedNumbers[mid]) / 2.0;
        }
        else
        {
            return sortedNumbers[mid];
        }
    }
}

public class StatisticsTests
{
    [Fact]
    public void CalculateMedian_OddNumberOfElements_ReturnsMiddleElement()
    {
        // Arrange
        int[] numbers = { 1, 3, 5, 7, 9 };

        // Act
        double median = Statistics.CalculateMedian(numbers);

        // Assert
        Assert.Equal(5, median);
    }

    [Fact]
    public void CalculateMedian_EvenNumberOfElements_ReturnsAverageOfMiddleElements()
    {
        // Arrange
        int[] numbers = { 1, 3, 5, 7, 9, 11 };

        // Act
        double median = Statistics.CalculateMedian(numbers);

        // Assert
        Assert.Equal(6, median);
    }

    [Fact]
    public void CalculateMedian_EmptyArray_ThrowsArgumentException()
    {
        // Arrange
        int[] numbers = { };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Statistics.CalculateMedian(numbers));
    }

    [Fact]
    public void CalculateMedian_NullArray_ThrowsArgumentException()
    {
        // Arrange
        int[] numbers = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Statistics.CalculateMedian(numbers));
    }

    [Fact]
    public void CalculateMedian_SingleElement_ReturnsThatElement()
    {
        // Arrange
        int[] numbers = { 42 };

        // Act
        double median = Statistics.CalculateMedian(numbers);

        // Assert
        Assert.Equal(42, median);
    }
}
