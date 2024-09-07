using System;

namespace RangeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 58
            //дополнить диапазон целых чисел не достающими

            string rawRange;
            List<int> rangeList = new List<int>();
            RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
            try
            {
                int firstNumber, secondNumber;
                Console.WriteLine("Enter a range of numbers:");
                rawRange = Console.ReadLine() ?? string.Empty;
                rangeProblemFunctions.Validate(rawRange);
                rangeList = RangeProblemFunctions.RawRangeSplit(rawRange);

                if (rangeList.Count == 2)
                {
                    firstNumber = rangeList[0];
                    secondNumber = rangeList[1];
                    rangeProblemFunctions.ValidateNeighboorNumbers(firstNumber, secondNumber);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            
            int minNumberOfRange = rangeList.Min();
            int maxNumberOfRange = rangeList.Max();

            var resultForLoop = rangeProblemFunctions.MissingNumbersForLoop(minNumberOfRange, maxNumberOfRange, rangeList);
            var resultWhileLoop = rangeProblemFunctions.MissingNumbersWhileLoop(minNumberOfRange, maxNumberOfRange, rangeList);
            var resultFillRangeList = rangeProblemFunctions.FillRangeList(minNumberOfRange, maxNumberOfRange, rangeList);


            RangeProblemFunctions.RangeOutput(resultForLoop);
            RangeProblemFunctions.RangeOutput(resultWhileLoop);
            RangeProblemFunctions.RangeOutput(resultFillRangeList);
        }
    }
}