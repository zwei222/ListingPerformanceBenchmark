using System.Runtime.InteropServices;

namespace ListingPerformanceBenchmark;

public static class ListingUtility
{
    public static List<int> CreateFibonacciListUsingNew(int length)
    {
        var result = new List<int>(length);

        for (var index = 0; index < length; index++)
        {
            if (index > 1)
            {
                result.Add(result[index - 2] + result[index - 1]);
            }
            else
            {
                result.Add(1);
            }
        }

        return result;
    }

    public static int[] CreateFibonacciArrayUsingNew(int length)
    {
        var result = new int[length];

        for (var index = 0; index < result.Length; index++)
        {
            if (index > 1)
            {
                result[index] = result[index - 2] + result[index - 1];
            }
            else
            {
                result[index] = 1;
            }
        }

        return result;
    }

    public static List<int> CreateFibonacciListUsingSpan(int length)
    {
        var result = new List<int>(length);

        CollectionsMarshal.SetCount(result, length);

        var span = CollectionsMarshal.AsSpan(result);

        for (var index = 0; index < span.Length; index++)
        {
            if (index > 1)
            {
                span[index] = span[index - 2] + span[index - 1];
            }
            else
            {
                span[index] = 1;
            }
        }

        return result;
    }

    public static int[] CreateFibonacciArrayUsingSpan(int length)
    {
        var result = new int[length];
        var span = result.AsSpan();

        for (var index = 0; index < span.Length; index++)
        {
            if (index > 1)
            {
                span[index] = span[index - 2] + span[index - 1];
            }
            else
            {
                span[index] = 1;
            }
        }

        return result;
    }

    public static int SumFibonacciListUsingNewFor(List<int> arg)
    {
        var sum = 0;
        var length = arg.Count;

        for (var index = 0; index < length; index++)
        {
            sum += arg[index];
        }

        return sum;
    }

    public static int SumFibonacciListUsingNewForEach(List<int> arg)
    {
        var sum = 0;

        foreach (var item in arg)
        {
            sum += item;
        }

        return sum;
    }

    public static int SumFibonacciListUsingSpanFor(List<int> arg)
    {
        var span = CollectionsMarshal.AsSpan(arg);
        var sum = 0;

        for (var index = 0; index < span.Length; index++)
        {
            sum += span[index];
        }

        return sum;
    }

    public static int SumFibonacciListUsingSpanForEach(List<int> arg)
    {
        var span = CollectionsMarshal.AsSpan(arg);
        var sum = 0;

        foreach (var item in span)
        {
            sum += item;
        }

        return sum;
    }

    public static int SumFibonacciArrayUsingNewFor(int[] arg)
    {
        var sum = 0;

        for (var index = 0; index < arg.Length; index++)
        {
            sum += arg[index];
        }

        return sum;
    }

    public static int SumFibonacciArrayUsingNewForEach(int[] arg)
    {
        var sum = 0;

        foreach (var item in arg)
        {
            sum += item;
        }

        return sum;
    }

    public static int SumFibonacciArrayUsingSpanFor(int[] arg)
    {
        var span = arg.AsSpan();
        var sum = 0;

        for (var index = 0; index < span.Length; index++)
        {
            sum += span[index];
        }

        return sum;
    }

    public static int SumFibonacciArrayUsingSpanForEach(int[] arg)
    {
        var span = arg.AsSpan();
        var sum = 0;

        foreach (var item in span)
        {
            sum += item;
        }

        return sum;
    }
}