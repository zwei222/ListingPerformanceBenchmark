using Xunit;

namespace ListingPerformanceBenchmark.Test;

public class ListingUtilityTest
{
    [Fact]
    public void CreateFibonacciListTest()
    {
        // Create Test
        Assert.Equal(
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 },
            ListingUtility.CreateFibonacciListUsingNew(10));
        Assert.Equal(
            ListingUtility.CreateFibonacciListUsingNew(10),
            ListingUtility.CreateFibonacciListUsingSpan(10));
        Assert.Equal(
            ListingUtility.CreateFibonacciArrayUsingNew(10),
            ListingUtility.CreateFibonacciArrayUsingSpan(10));

        // Sum Test
        var list = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
        var sum = list.Sum();

        Assert.Equal(sum, ListingUtility.SumFibonacciListUsingNewFor(list));
        Assert.Equal(sum, ListingUtility.SumFibonacciListUsingNewForEach(list));
        Assert.Equal(sum, ListingUtility.SumFibonacciListUsingSpanFor(list));
        Assert.Equal(sum, ListingUtility.SumFibonacciListUsingSpanForEach(list));

        var array = list.ToArray();

        Assert.Equal(sum, ListingUtility.SumFibonacciArrayUsingNewFor(array));
        Assert.Equal(sum, ListingUtility.SumFibonacciArrayUsingNewForEach(array));
        Assert.Equal(sum, ListingUtility.SumFibonacciArrayUsingSpanFor(array));
        Assert.Equal(sum, ListingUtility.SumFibonacciArrayUsingSpanForEach(array));
    }
}