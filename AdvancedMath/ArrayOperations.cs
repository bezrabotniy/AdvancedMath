using System;

namespace AdvancedMath
{
    /// <summary>
    /// Класс для выполнения операций над массивами.
    /// </summary>
    public static class ArrayOperations
    {
        /// <summary>
        /// Вычисляет среднее значение элементов массива.
        /// </summary>
        /// <param name="values">Массив значений.</param>
        /// <returns>Среднее значение элементов массива.</returns>
        public static double CalculateArrayMean(double[] values)
        {
            double sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum / values.Length;
        }

        /// <summary>
        /// Вычисляет стандартное отклонение элементов массива.
        /// </summary>
        /// <param name="values">Массив значений.</param>
        /// <returns>Стандартное отклонение элементов массива.</returns>
        public static double CalculateStandardArrayDeviation(double[] values)
        {
            double mean = CalculateArrayMean(values);
            double sumSquaredDifferences = 0;
            foreach (var value in values)
            {
                sumSquaredDifferences += Math.Pow(value - mean, 2);
            }
            return Math.Sqrt(sumSquaredDifferences / values.Length);
        }
    }
}