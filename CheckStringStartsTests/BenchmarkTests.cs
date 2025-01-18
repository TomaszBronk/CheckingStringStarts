public class BenchmarkTests
{
    private readonly Benchmark _benchmark = new Benchmark();

    [Theory]
    [InlineData(".example", true)]
    [InlineData("example", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void TestStartsWithDotString(string input, bool expected)
    {

        var result = _benchmark.StartsWithDotString(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(".example", true)]
    [InlineData("example", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void TestStartsWithDotChar(string input, bool expected)
    {
        var result = _benchmark.StartsWithDotChar(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(".example", true)]
    [InlineData("example", false)]
    [InlineData("", false)]
    public void TestStartsWithDotSpan(string input, bool expected)
    {
        var result = _benchmark.StartsWithDotSpan(input.AsSpan());
        Assert.Equal(expected, result);
    }
}
