using System;
using Xunit;
using ProjectCode;

namespace ProjectTest
{
    public class ArrayHelperTests
    {
        [Fact]
        public void FindMax_ReturnsMaxValue()
        {
            int[] numbers = { 3, 5, 7, 2, 8 };
            int result = ArrayHelper.FindMax(numbers);
            Assert.Equal(8, result);
        }

        [Fact]
        public void FindMin_ReturnsMinValue()
        {
            int[] numbers = { 3, 5, 7, 2, 8 };
            int result = ArrayHelper.FindMin(numbers);
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMax_ThrowsExceptionForEmptyArray()
        {
            int[] numbers = { };
            Assert.Throws<ArgumentException>(() => ArrayHelper.FindMax(numbers));
        }

        [Fact]
        public void FindMin_ThrowsExceptionForEmptyArray()
        {
            int[] numbers = { };
            Assert.Throws<ArgumentException>(() => ArrayHelper.FindMin(numbers));
        }
    }
}
