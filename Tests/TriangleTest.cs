using CsharpTestTask.figures;

namespace Tests
{
    /// <summary>
    /// Так как используем double, тестируем с ограниченной точностью.
    /// В кач-ве альтернативы, можно было всё написать на decimal.
    /// </summary>
    public class TriangleTest
    {
        [Fact]
        public void TriangleAreaTest()
        {
            Triangle trig = new(46, 29, 51);
            Assert.True(Math.Abs(trig.GetArea() - 661d) < 0.1d, $"Завален. Ожидали 661d, получили: {trig.GetArea()}");
        }

        [Fact]
        public void TriangleInvalidParamTest1()
        {
            try
            {
                Triangle trig = new(1, 0, -1);
            }
            catch (Exception ex)
            {
                Assert.True(true);
                return;
            }
            Assert.Fail("Ожидали что всё упадет");
        }

        [Fact]
        public void TriangleInvalidParamTest2()
        {
            try
            {
                Triangle trig = new(200, 100, 5);
            }
            catch (Exception ex)
            {
                Assert.True(true);
                return;
            }
            Assert.Fail("Ожидали что всё упадет");
        }


        [Fact]
        public void TriangleIsRightTest1()
        {
            Triangle trig = new(3, 4, 5);
            Assert.True(trig.isRight());
        }

        [Fact]
        public void TriangleIsRightTest2()
        {
            Triangle trig = new(46, 29, 51);
            Assert.False(trig.isRight());
        }
    }
}