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
        public Circle(double radius)
        {
            _radius = radius;
        }
        #endregion


        #region Public Methods
        ///<inheritdoc cref="Figure.GetArea"/>
        public override double GetArea()
        {
            return 2 * Math.PI * _radius;
        }
        #endregion
    }
}
