using System;

namespace Refactoring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WriteUserGreeting();

            string userInput = Console.ReadLine();

            if (TryExitProgram(userInput))
                return;

            int inputNumber = Int32.Parse(userInput);

            FactorialCalculateAndReport(inputNumber);

            SumCalculateAndReport(inputNumber);

            MaxEvenNumberCalculateAndReport(inputNumber);

            Console.ReadLine();
        }

        private static void WriteUserGreeting()
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.WriteLine("Для выхода из программы введите q ");
            Console.WriteLine("Пожалуйста, введите число: ");
        }

        private static bool TryExitProgram(string userInput)
        {
            if (userInput == "q")
            {
                return true;
            }

            return false;
        }

        private static void FactorialCalculateAndReport(int inputNumber)
        {
            var factorialCalculator = new FactorialForLoopCalculator();
            int factorial = factorialCalculator.Calculate(inputNumber);
            Console.WriteLine("Факториал равен: " + factorial);
        }

        private static void SumCalculateAndReport(int inputNumber)
        {
            var sumCalculator = new SumForLoopCalculator();
            int sum = sumCalculator.Calculate(inputNumber);
            Console.WriteLine("Сума от 1 до N равна " + sum);
        }

        private static void MaxEvenNumberCalculateAndReport(int inputNumber)
        {
            var maxEvenNumberCalculate = new MaxEvenNumberForLoopCalculate();
            int maxEvenNumber = maxEvenNumberCalculate.Calculate(inputNumber);
            Console.WriteLine("максимальное четное число меньше N равно" + maxEvenNumber);
        }
    }
}