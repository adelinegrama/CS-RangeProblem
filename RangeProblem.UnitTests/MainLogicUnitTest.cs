using System;
using RangeProblem;

namespace RangeProblem.UnitTests;

[TestClass]
public class MainLogicUnitTest
{
    [TestMethod]
    public void MainLogic_ForLoopTest()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        int min = 2;
        int max = 10;
        List<int> range = new List<int>() { min, 5, 7, max };
        var expected = new List<int>() { 3, 4, 6, 8, 9 };

        var actual = rangeProblemFunctions.MissingNumbersForLoop(min, max, range);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void MainLogic_WhileLoop_LargeRangeTest()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        int min = -5;
        int max = 20;
        List<int> range = new List<int>() { min, -2, 0, 5, max };
        var expected = new List<int>() { -4, -3, -1, 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

        var actual = rangeProblemFunctions.MissingNumbersWhileLoop(min, max, range);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void MainLogicFillRangeListTest()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        int min = 0;
        int max = 5;
        List<int> range = new List<int>() { min, max };
        var expected = new List<int>() { 1, 2, 3, 4 };

        var actual = rangeProblemFunctions.FillRangeList(min, max, range);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void MainLogic_SmallRangeTest()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        int min = -1;
        int max = 2;
        List<int> range = new List<int>() { min, 0, max };
        var expected = new List<int>() { 1 };

        var actual = rangeProblemFunctions.FillRangeList(min, max, range);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void MainLogic_LargeRange_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        int min = 1;
        int max = 100;
        List<int> range = new List<int>() { min, 50, max };
        var expected = Enumerable.Range(min + 1, max - min).Where(n => n < max && !range.Contains(n)).ToList();

        var actual = rangeProblemFunctions.FillRangeList(min, max, range);
        
        CollectionAssert.AreEqual(expected, actual);
    }
}