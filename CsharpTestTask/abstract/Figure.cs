namespace CsharpTestTask.@abstract
{
    /// <summary>
    /// Базовый класс для фигур в библиотеке
    /// 
    /// Позволяет добавлять дургие фигуры на базе себя и вычислять площать произвольой фигуры, если её тип заранее неизвестен.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Получить площать фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double GetArea();
    }
}
