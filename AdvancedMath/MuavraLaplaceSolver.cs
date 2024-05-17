using System;

namespace AdvancedMath
{
    /// <summary>
    /// Класс для решения задачи по теореме Муавра-Лапласа с точным значением K.
    /// </summary>
    public class MuavraLaplaceSolverWithStableK
    {
        private readonly double p;
        private readonly int k;
        private readonly int n;

        /// <summary>
        /// Инициализирует новый экземпляр класса MuavraLaplaceSolverWithStableK.
        /// </summary>
        /// <param name="p">Вероятность наступления события.</param>
        /// <param name="k">Количество наступлений события.</param>
        /// <param name="n">Общее количество испытаний.</param>
        public MuavraLaplaceSolverWithStableK(double p, int k, int n)
        {
            this.p = p;
            this.k = k;
            this.n = n;
        }

        /// <summary>
        /// Вычисляет вероятность наступления события.
        /// </summary>
        /// <returns>Вероятность наступления события.</returns>
        public double CalculateProbability()
        {
            double q = 1 - p;
            double part1 = 1 / Math.Sqrt(n * p * q);
            double part2 = (k - n * p) / Math.Sqrt(n * p * q);
            double part3 = (1 / Math.Sqrt(2 * Math.PI)) * Math.Exp((-1 * part2 * part2) / 2);
            double part4 = part1 * part3;
            return part4;
        }
    }
}