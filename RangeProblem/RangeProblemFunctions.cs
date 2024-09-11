using System.Text.RegularExpressions;

namespace RangeProblem;

public class RangeProblemFunctions
{
    public void ValidateNeighboorNumbers(int firstNumber, int secondNumber)
    {
        if (Math.Abs(firstNumber - secondNumber) == 1)
        {
            throw new ArgumentException("Do not enter neighboor numbers!");
        }
    }

    public void Validate(string? rawRange)
    {
        if (string.IsNullOrEmpty(rawRange) || string.IsNullOrWhiteSpace(rawRange))
        {
            throw new ArgumentException("String cannot be null, empty or white space!");
        }

        if (rawRange.Length == 1)
        {
            throw new ArgumentException("You must enter more than 1 number!");
        }

        if (Regex.IsMatch(rawRange, @"^[a-zA-Z]+$"))
        {
            throw new ArgumentException("You cannot use letters");
        }
    }

    public static List<int> RawRangeSplit(string rawRange)
    {
        List<int> rangeList = new List<int>();
        if (rawRange.Contains(' ') && !rawRange.Contains(','))
        {
            string[] rawRangeString = rawRange.Split(' ');
            rangeList = rawRangeString.Select(int.Parse).ToList();
        }
        else if (rawRange.Contains(", "))
        {
            string[] rawRangeString = rawRange.Split(", ");
            rangeList = rawRangeString.Select(int.Parse).ToList();
        }
        else if (rawRange.Contains(',') && !rawRange.Contains(' '))
        {
            string[] rawRangeString = rawRange.Split(',');
            rangeList = rawRangeString.Select(int.Parse).ToList();
        }

        return rangeList;
    }

    public List<int> MissingNumbersForLoop(int minNumberOfRange, int maxNumberOfRange, List<int> rangeList)
    {
        Console.WriteLine("In for loop.");
        List<int> result = new List<int>();
        for (int missingNumber = minNumberOfRange; missingNumber < maxNumberOfRange; missingNumber++)
        {
            if (rangeList.Contains(missingNumber))
            {
                continue;
            }
            result.Add(missingNumber);
        }
        return result;
    }

    public List<int> MissingNumbersWhileLoop(int minNumberOfRange, int maxNumberOfRange, List<int> rangeList)
    {
        List<int> result = new List<int>();
        int missingNumber = minNumberOfRange;
        while (missingNumber < maxNumberOfRange)
        {
            missingNumber++;
            if (rangeList.Contains(missingNumber))
            {
                continue;
            }
            result.Add(missingNumber);
        }
        Console.WriteLine("In while loop.");
        return result;
    }

    public List<int> FillRangeList(int minNumberOfRange, int maxNumberOfRange, List<int> rangeList)
    {
        rangeList = Enumerable.Range(minNumberOfRange + 1, maxNumberOfRange - minNumberOfRange)
                    .Where(n => n < maxNumberOfRange && !rangeList.Contains(n))
                    .ToList();
        Console.WriteLine("In fill range list method.");
        return rangeList;
    }

    public static void RangeOutput(List<int> rangeListOutput)
    {
        foreach (var number in rangeListOutput)
        {
            Console.WriteLine(number);
        }
    }
}