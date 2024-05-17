using System;

namespace AdvancedMath
{
    /// <summary>
    /// Класс для работы с комплексными числами.
    /// </summary>
    public class ComplexNumber
    {
        public double Real { get; }
        public double Imaginary { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса ComplexNumber.
        /// </summary>
        /// <param name="real">Действительная часть.</param>
        /// <param name="imaginary">Мнимая часть.</param>
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary, c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            return new ComplexNumber((c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator, (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator);
        }

        /// <summary>
        /// Возвращает строковое представление комплексного числа.
        /// </summary>
        /// <returns>Строковое представление комплексного числа.</returns>
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        /// <summary>
        /// Вычисляет модуль комплексного числа.
        /// </summary>
        /// <returns>Модуль комплексного числа.</returns>
        public double Magnitude()
        {
            return Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }

        /// <summary>
        /// Вычисляет аргумент комплексного числа.
        /// </summary>
        /// <returns>Аргумент комплексного числа в радианах.</returns>
        public double Phase()
        {
            return Math.Atan2(Imaginary, Real);
        }
    }
}