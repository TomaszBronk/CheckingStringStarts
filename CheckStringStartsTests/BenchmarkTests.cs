using BenchmarkDotNet.Running;
using Xunit;

public class BenchmarkTests
{
    [Theory]
    [InlineData(".example", true)]
    [InlineData("example", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void TestStartsWithDotString(string input, bool expected)
    {
        var benchmark = new Benchmark();
        var result = benchmark.StartsWithDotString(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(".example", true)]
    [InlineData("example", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void TestStartsWithDotChar(string input, bool expected)
    {
        var benchmark = new Benchmark();
        var result = benchmark.StartsWithDotChar(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(".example", true)]
    [InlineData("example", false)]
    [InlineData("", false)]
    public void TestStartsWithDotSpan(string input, bool expected)
    {
        var benchmark = new Benchmark();
        var result = benchmark.StartsWithDotSpan(input.AsSpan());
        Assert.Equal(expected, result);
    }
}
