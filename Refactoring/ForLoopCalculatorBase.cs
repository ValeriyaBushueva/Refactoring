namespace Refactoring
{
    public abstract class ForLoopCalculatorBase
    {
        public int Calculate(int loopLenght)
        {
            for (int i = 1; i <= loopLenght; i++)
            {
                CalculateByIndex(i);
            }

            return GetValue();
        }

        protected abstract int GetValue();
        
        protected abstract void CalculateByIndex(int i);
    }
}