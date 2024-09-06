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


            //Задание 59
            //проверить, можно ли из заданной последовательности целых чисел 
            //создать строго возрастающую последовательность в виде массива

            //Задание 63
            //check if a given number is present in an array of numbers

            //Задание  65
            //умножить все элементы заданного массива чисел на длину массива

            //Задание 67
            //create a coded string from a given string, using a specified formula.
            //Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.

            //Задание 69
            //check if a given string contains only lowercase or uppercase characters

            //Задание 71
            //given string contains two similar consecutive letters

            //Задание 72
            //check whether the average value of the elements of a given array of numbers is a whole number or not

            //Задание 73
            //convert the letters of a given string (same case-upper/lower) into alphabetical order

            //Задание 74
            //check the length of a given string is odd or even

            //Задание 75
            //takes a positive number and returns the nth odd number

            //Задание 76
            //get the ASCII value of a given character

            //Задание 77
            //check whether a word is plural or not

            //Задание 82
            //remove all non-letter characters from a given string

            //Задание 83
            //remove all vowels from a given string

            //Задание 84
            //get the index number of all lower case letters in a given string.

            //Задание 86
            //get the number of letters and digits in a given string

        }
    }
}