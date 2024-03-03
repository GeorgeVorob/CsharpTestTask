using CsharpTestTask.@abstract;

namespace CsharpTestTask.figures
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : Figure
    {
        #region Private Props
        /// <summary>
        /// Радиус круга
        /// </summary>
        private double _radius { get; set; }
        #endregion

        #region Constructors
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше или равен нулю");
            _radius = radius;
        }
        #endregion


        #region Public Methods
        ///<inheritdoc cref="Figure.GetArea"/>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        #endregion
    }
}
