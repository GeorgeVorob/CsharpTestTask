using CsharpTestTask.@abstract;

namespace CsharpTestTask.figures
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : Figure
    {
        #region Private Props
        // Стороны треугольника
        private double _sideA { get; set; }
        private double _sideB { get; set; }
        private double _sideC { get; set; }
        #endregion

        #region Constructors
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        #endregion

        #region Public Methods
        /// <param name="radius">Радиус круга</param>
        public override double GetArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            double area = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return area;
        }

        /// <summary>
        /// Возвращает признак, является-ли треугольник прямоугольным
        /// </summary>
        /// <returns>Признак, является-ли треугольник прямоугольным</returns>
        public bool isRight()
        {
            // Через серию проверок находим потенциальную гипотенузу
            double gip = _sideA;
            double cat1 = _sideB;
            double cat2 = _sideC;

            if(_sideA > _sideB && _sideA > _sideC)
            {
                gip = _sideA;
                cat1 = _sideB;
                cat2 = _sideC;
            }

            if (_sideB > _sideA && _sideB > _sideC)
            {
                gip = _sideB;
                cat1 = _sideA;
                cat2 = _sideC;
            }

            if (_sideC > _sideA && _sideC > _sideB)
            {
                gip = _sideC;
                cat1 = _sideA;
                cat2 = _sideB;
            }

            return Math.Pow(gip, 2) == Math.Pow(cat1, 2) + Math.Pow(cat2, 2);
        }
        #endregion
    }
}
