namespace Refactoring
{
    public class MaxEvenNumberForLoopCalculate : ForLoopCalculatorBase
    {
        private int maxEvenNumber;

        protected override int GetValue() => maxEvenNumber;

        protected override void CalculateByIndex(int i)
        {
            if (i % 2 == 0)
            {
                maxEvenNumber = i;
            }
        }
    }
}