public interface IOperations
{
    double CalculateProbability();
    double CalculateArrayMean(double[] values);
    double CalculateStandardArrayDeviation(double[] values);
    double NewtonRaphsonMethod(Func<double, double> function, Func<double, double> derivative, double initialGuess, double tolerance, int maxIterations);
    double NumericalIntegration(Func<double, double> function, double lowerBound, double upperBound, int numIntervals);
    double[] SolveDifferentialEquationEuler(Func<double, double, double> derivative, double initialValueX, double initialValueY, double stepSize, double endTime);
    double[] RungeKuttaSolver(Func<double, double, double> differentialEquation, double initialValueX, double initialValueY, double stepSize, double endTime);
}