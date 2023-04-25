namespace XUnitTest.Utils;
// Function want to test.
public static class MathUtilities
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

public class MathUtilitiesTest
{
    [Fact]
    public void PassingTest()
    {
        int a = 2;
        int b = 2;
        int expectedSum = 4;
        int actualSum = MathUtilities.Add(a, b);
        Assert.Equal(expectedSum, actualSum);
    }

    [Fact]
    public void FailingTest()
    {
        int a = 2;
        int b = 2;
        int expectedSum = 5;
        int actualSum = MathUtilities.Add(a, b);
        Assert.Equal(expectedSum, actualSum);
    }
}