using CsharpTestTask.figures;

namespace Tests
{
    /// <summary>
    /// Так как используем double, тестируем с ограниченной точностью.
    /// В кач-ве альтернативы, можно было всё написать на decimal.
    /// </summary>
    public class CircleTest
    {
        [Fact]
        public void CircleAreaTest()
        {
            Circle cir = new(5);
            Assert.True(Math.Abs(cir.GetArea() - 78.53d) < 0.01d, $"Завален. Ожидали 78.53d, получили: {cir.GetArea()}");
        }

        [Fact]
        public void CircleInvalidParamTest()
        {
            try
            {
                Circle cir = new(-5);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(true);
                return;
            }
            Assert.Fail("Ожидали что всё упадет");
        }
    }
}