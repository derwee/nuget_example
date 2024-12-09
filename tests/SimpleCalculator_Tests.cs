using simple_example;
using Xunit;

namespace tests
{
    public class SimpleCalculator_Tests
    {
        [Fact]
        public void PositiveTest()
        {
            var instance = new SimpleCalculator();
            var actual = instance.Add(2, 1);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void NegativeTest()
        {
            var instance = new SimpleCalculator();
            var actual = instance.Add(-2, 1);

            Assert.Equal(-1, actual);
        }
    }
}
