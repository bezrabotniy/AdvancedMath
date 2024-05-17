using System;

namespace AdvancedMath
{
    /// <summary>
    /// Класс для решения дифференциальных уравнений.
    /// </summary>
    public static class Differentiaton
    {
        /// <summary>
        /// Решает дифференциальное уравнение методом Эйлера.
        /// </summary>
        /// <param name="derivative">Функция производной (дифференциальное уравнение).</param>
        /// <param name="initialValueX">Начальное значение переменной x.</param>
        /// <param name="initialValueY">Начальное значение переменной y.</param>
        /// <param name="stepSize">Шаг интегрирования.</param>
        /// <param name="endTime">Конечное время.</param>
        /// <returns>Массив значений переменной y.</returns>
        public static double[] SolveDifferentialEquationEuler(Func<double, double, double> derivative, double initialValueX, double initialValueY, double stepSize, double endTime)
        {
            int numSteps = (int)(endTime / stepSize);
            double[] resultX = new double[numSteps + 1];
            double[] resultY = new double[numSteps + 1];
            resultX[0] = initialValueX;
            resultY[0] = initialValueY;

            for (int i = 0; i < numSteps; i++)
            {
                double x = resultX[i];
                double y = resultY[i];
                double dydx = derivative(x, y);
                double newX = x + stepSize;
                double newY = y + stepSize * dydx;
                resultX[i + 1] = newX;
                resultY[i + 1] = newY;
            }

            return resultY;
        }

        /// <summary>
        /// Решает дифференциальное уравнение методом Рунге-Кутты 4-го порядка.
        /// </summary>
        /// <param name="differentialEquation">Функция дифференциального уравнения.</param>
        /// <param name="initialValueX">Начальное значение x.</param>
        /// <param name="initialValueY">Начальное значение y.</param>
        /// <param name="stepSize">Шаг интегрирования.</param>
        /// <param name="endTime">Конечное время.</param>
        /// <returns>Массив значений переменной y.</returns>
        public static double[] RungeKuttaSolver(Func<double, double, double> differentialEquation, double initialValueX, double initialValueY, double stepSize, double endTime)
        {
            int numSteps = (int)((endTime - initialValueX) / stepSize) + 1;
            double[] resultX = new double[numSteps];
            double[] resultY = new double[numSteps];
            resultX[0] = initialValueX;
            resultY[0] = initialValueY;

            for (int i = 1; i < numSteps; i++)
            {
                double x0 = resultX[i - 1];
                double y0 = resultY[i - 1];
                double k1 = stepSize * differentialEquation(x0, y0);
                double k2 = stepSize * differentialEquation(x0 + stepSize / 2, y0 + k1 / 2);
                double k3 = stepSize * differentialEquation(x0 + stepSize / 2, y0 + k2 / 2);
                double k4 = stepSize * differentialEquation(x0 + stepSize, y0 + k3);
                double slope = (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                resultX[i] = x0 + stepSize;
                resultY[i] = y0 + slope;
            }

            return resultY;
        }
    }
}