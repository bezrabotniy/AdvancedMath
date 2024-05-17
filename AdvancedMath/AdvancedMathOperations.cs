using System;

namespace AdvancedMath
{
    /// <summary>
    /// Класс для выполнения расширенных математических операций.
    /// </summary>
    public static class ExtraMathOperations
    {
        /// <summary>
        /// Метод Ньютона-Рафсона для нахождения корня уравнения.
        /// </summary>
        /// <param name="function">Функция, корень которой нужно найти.</param>
        /// <param name="derivative">Производная функции.</param>
        /// <param name="initialGuess">Начальное приближение.</param>
        /// <param name="tolerance">Погрешность.</param>
        /// <param name="maxIterations">Максимальное количество итераций.</param>
        /// <returns>Найденный корень уравнения.</returns>
        public static double NewtonRaphsonMethod(Func<double, double> function, Func<double, double> derivative, double initialGuess, double tolerance, int maxIterations)
        {
            double x0 = initialGuess;
            double x1 = x0 - function(x0) / derivative(x0);
            int iteration = 0;

            while (Math.Abs(x1 - x0) > tolerance && iteration < maxIterations)
            {
                x0 = x1;
                x1 = x0 - function(x0) / derivative(x0);
                iteration++;
            }

            return x1;
        }

        /// <summary>
        /// Выполняет численное интегрирование функции методом трапеций.
        /// </summary>
        /// <param name="function">Функция для интегрирования.</param>
        /// <param name="lowerBound">Нижний предел интегрирования.</param>
        /// <param name="upperBound">Верхний предел интегрирования.</param>
        /// <param name="numIntervals">Количество интервалов разбиения.</param>
        /// <returns>Результат численного интегрирования.</returns>
        public static double NumericalIntegration(Func<double, double> function, double lowerBound, double upperBound, int numIntervals)
        {
            double intervalWidth = (upperBound - lowerBound) / numIntervals;
            double result = 0;

            for (int i = 0; i < numIntervals; i++)
            {
                double left = lowerBound + i * intervalWidth;
                double right = lowerBound + (i + 1) * intervalWidth;
                result += (function(left) + function(right)) / 2 * intervalWidth;
            }

            return result;
        }
    }
}