using DivisionWithARemainder;

namespace DivisionWithARemainderTests
{
    public class DivisionWithARemainderTests
    {
        [Theory]
        [InlineData(2, "The number is even.")]
        [InlineData(-3, "The number is odd.")]
        public void CheckEvenOrOdd_WithCheckTheRemainder_ShouldReturnIfisOddOrEven(int input, string evenorodd)
        {
            string result = DivisionWithARemainder.CheckEvenOrOdd(input);
            Assert.Equal(evenorodd, result);
        }
        [Theory]
        [InlineData(26, "The number is odd.")]
        [InlineData(10, "The number is odd.")]
        public void CheckEvenOrOdd_WithInvalidCondition_ShouldNotNatch(int input, string evenorodd)
        {
            string result = DivisionWithARemainder.CheckEvenOrOdd(evenorodd);
            Assert.Equal(evenorodd, result);           
        }

    }
}