namespace Refactoring
{
    public class SumForLoopCalculator : ForLoopCalculatorBase
    {
        private int sum = 0;
        
        protected override int GetValue() => sum;

        protected override void CalculateByIndex(int i) => sum += i;
    }
}