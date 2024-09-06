using System;
using RangeProblem;

namespace RangeProblem.UnitTests;

[TestClass]
public class HadlingExceptionsUnitTest
{
    [TestMethod]
    public void HandlingExceptions_Letters_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        string range = "sldkgfnfdk";
        var exceptionLetters = Assert.ThrowsException<ArgumentException>(() => rangeProblemFunctions.Validate(range));
        Assert.AreEqual("You cannot use letters", exceptionLetters.Message);
    }

    [TestMethod]
    public void HandlingExceptions_LengthIsOne_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        string range = "2";
        var expectionLengthIsOne = Assert.ThrowsException<ArgumentException>(() => rangeProblemFunctions.Validate(range));
        Assert.AreEqual("You must enter more than 1 number!", expectionLengthIsOne.Message);
    }

    [TestMethod]
    public void HandlingExceptions_StringIsNull_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        string? range = null;
        var exceptionNull = Assert.ThrowsException<ArgumentException>(() => rangeProblemFunctions.Validate(range));
        Assert.AreEqual("String cannot be null, empty or white space!", exceptionNull.Message);
    }

    [TestMethod]
    public void HandlingExceptions_StringIsEmpty_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        string range = "";
        var exceptionEmpty = Assert.ThrowsException<ArgumentException>(() => rangeProblemFunctions.Validate(range));
        Assert.AreEqual("String cannot be null, empty or white space!", exceptionEmpty.Message);
    }

    [TestMethod]
    public void HandlingExceptions_StringIsWhiteSpace_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        string range = "  ";
        var exceptionWhiteSpace = Assert.ThrowsException<ArgumentException>(() => rangeProblemFunctions.Validate(range));
        Assert.AreEqual("String cannot be null, empty or white space!", exceptionWhiteSpace.Message);   
    }

    [TestMethod]
    public void HandlingExceptions_NeighboorNumbers_FirstNumberIsLessThanSecondNumber_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        int firstNumber = 34;
        int secondNumber = 35;
        var exceptionNeighboorNumbers = Assert.ThrowsException<ArgumentException>(
            () => rangeProblemFunctions.ValidateNeighboorNumbers(firstNumber, secondNumber));
        Assert.AreEqual("Do not enter neighboor numbers!", exceptionNeighboorNumbers.Message);
    }

    [TestMethod]
    public void HandlingExceptions_NeighboorNumbers_FirstNumberIsGreaterThanSecondNumber_Test()
    {
        RangeProblemFunctions rangeProblemFunctions = new RangeProblemFunctions();
        int firstNumber = 35;
        int secondNumber = 34;
        var exceptionNeighboorNumbers = Assert.ThrowsException<ArgumentException>(
            () => rangeProblemFunctions.ValidateNeighboorNumbers(firstNumber, secondNumber));
        Assert.AreEqual("Do not enter neighboor numbers!", exceptionNeighboorNumbers.Message);
    }
}