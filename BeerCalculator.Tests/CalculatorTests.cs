using BeerCalculatorClassLibrary;
using System;
using System.Drawing;
using Xunit;

namespace BeerCalculator.Tests
{
    public class CalculatorTests
    {


        [Theory]
        [InlineData(0)]
        [InlineData(-25)]
        [InlineData(double.MinValue)]
        public void GetColor_AnySrmBelowOne_ShouldReturnMinSrmColor(double srm)
        {
            // Arrange
            Color expected = Color.FromArgb(255, 230, 153);

            // Act
            var actual = Calculator.GetColor(
                srm);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(41)]
        [InlineData(150)]
        [InlineData(Double.MaxValue)]
        public void GetColor_AnySrmAboveForty_ShouldReturnMaxSrmColor(double srm)
        {
            // Arrange
            Color expected = Color.FromArgb(31, 5, 6);

            // Act
            var actual = Calculator.GetColor(
                srm);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(12, 1.012)]
        [InlineData(86, 1.086)]
        [InlineData(120, 1.120)]
        public void ConvertGravity_PositiveNumbers_CalculateCorrectly(double gravity, double expected)
        {
            // Arrange

            // Act
            var actual = Calculator.ConvertGravity(
                gravity);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(7, 7)]
        [InlineData(Double.MinValue, Double.MinValue)]
        public void ApplyMoreyEquation_AnySrmBelowEight_ReturnsOriginalNumber(double srm, double expected)
        {
            // Arrange

            // Act
            var actual = Calculator.ApplyMoreyEquation(
                srm);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(9, 9.3)]
        [InlineData(30, 30.8)]
        [InlineData(150, 154.2)]
        public void ApplyMoreyEquation_AnySrmAboveEight_CalculatesCorrectly(double srm, double expected)
        {
            // Arrange

            // Act
            var actual = Calculator.ApplyMoreyEquation(
                srm);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
