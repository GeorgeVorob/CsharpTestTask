using CsharpTestTask.figures;

namespace Tests
{
    /// <summary>
    /// ��� ��� ���������� double, ��������� � ������������ ���������.
    /// � ���-�� ������������, ����� ���� �� �������� �� decimal.
    /// </summary>
    public class CircleTest
    {
        [Fact]
        public void CircleAreaTest()
        {
            Circle cir = new(5);
            Assert.True(Math.Abs(cir.GetArea() - 78.53d) < 0.01d, $"�������. ������� 78.53d, ��������: {cir.GetArea()}");
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
            Assert.Fail("������� ��� �� ������");
        }
    }
}