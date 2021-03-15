using System;
using Xunit;

namespace LearningCSharp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Given (Arrange)
            // When (Act)
            // Then (Assert)

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5,3,8)]
        [InlineData(10,44,54)]
        public void CanAddTwoNumbers(int a, int b, int expected)
        {
            int sum = a + b;
            Assert.Equal(expected, sum);
        }
    }
}
