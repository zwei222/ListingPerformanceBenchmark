using BenchmarkDotNet.Attributes;

namespace ListingPerformanceBenchmark;

[MemoryDiagnoser]
public class Benchmark
{
    private readonly List<int> list = new() { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

    private readonly int[] array = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

    [Benchmark(Description = "Write List (new)")]
    [Arguments(10, Priority = 10)]
    [Arguments(100, Priority = 100)]
    [Arguments(1000, Priority = 1000)]
    [Arguments(10000, Priority = 10000)]
    public List<int> CreateFibonacciListUsingNew(int length) => ListingUtility.CreateFibonacciListUsingNew(length);

    [Benchmark(Description = "Write List (Span)")]
    [Arguments(10, Priority = 10)]
    [Arguments(100, Priority = 100)]
    [Arguments(1000, Priority = 1000)]
    [Arguments(10000, Priority = 10000)]
    public List<int> CreateFibonacciListUsingSpan(int length) => ListingUtility.CreateFibonacciListUsingSpan(length);

    [Benchmark(Description = "Write Array (new)")]
    [Arguments(10, Priority = 10)]
    [Arguments(100, Priority = 100)]
    [Arguments(1000, Priority = 1000)]
    [Arguments(10000, Priority = 10000)]
    public int[] CreateFibonacciArrayUsingNew(int length) => ListingUtility.CreateFibonacciArrayUsingNew(length);

    [Benchmark(Description = "Write Array (Span)")]
    [Arguments(10, Priority = 10)]
    [Arguments(100, Priority = 100)]
    [Arguments(1000, Priority = 1000)]
    [Arguments(10000, Priority = 10000)]
    public int[] CreateFibonacciArrayUsingSpan(int length) => ListingUtility.CreateFibonacciArrayUsingSpan(length);

    [Benchmark(Description = "Sum List (new) for")]
    public int SumFibonacciListUsingNewFor() => ListingUtility.SumFibonacciListUsingNewFor(this.list);

    [Benchmark(Description = "Sum List (new) foreach")]
    public int SumFibonacciListUsingNewForEach() => ListingUtility.SumFibonacciListUsingNewForEach(this.list);

    [Benchmark(Description = "Sum List (Span) for")]
    public int SumFibonacciListUsingSpanFor() => ListingUtility.SumFibonacciListUsingSpanFor(this.list);

    [Benchmark(Description = "Sum List (Span) foreach")]
    public int SumFibonacciListUsingSpanForEach() => ListingUtility.SumFibonacciListUsingSpanForEach(this.list);

    [Benchmark(Description = "Sum Array (new) for")]
    public int SumFibonacciArrayUsingNewFor() => ListingUtility.SumFibonacciArrayUsingNewFor(this.array);

    [Benchmark(Description = "Sum Array (new) foreach")]
    public int SumFibonacciArrayUsingNewForEach() => ListingUtility.SumFibonacciArrayUsingNewForEach(this.array);

    [Benchmark(Description = "Sum Array (Span) for")]
    public int SumFibonacciArrayUsingSpanFor() => ListingUtility.SumFibonacciArrayUsingSpanFor(this.array);

    [Benchmark(Description = "Sum Array (Span) foreach")]
    public int SumFibonacciArrayUsingSpanForEach() => ListingUtility.SumFibonacciArrayUsingSpanForEach(this.array);
}