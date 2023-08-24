using ListingPerformanceBenchmark;

var summary = BenchmarkDotNet.Running.BenchmarkRunner.Run<Benchmark>();
