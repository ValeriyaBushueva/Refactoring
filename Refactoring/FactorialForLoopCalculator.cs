namespace Refactoring
{
    public class FactorialForLoopCalculator : ForLoopCalculatorBase
    {
        private int factorial = 1;
        
        protected override int GetValue() => factorial;

        protected override void CalculateByIndex(int i) => factorial *= i;
    }
}