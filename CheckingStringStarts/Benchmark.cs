using BenchmarkDotNet.Attributes;

public class Benchmark
{
    private const string TestString = ".example";

    [Benchmark]
    public bool TestStartsWithDotString()
    {
        return StartsWithDotString(TestString);
    }

    [Benchmark]
    public bool TestStartsWithDotChar()
    {
        return StartsWithDotChar(TestString);
    }

    [Benchmark]
    public bool TestStartsWithDotSpan()
    {
        return StartsWithDotSpan(TestString.AsSpan());
    }

    public bool StartsWithDotString(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return false;
        }
        return str.StartsWith(".");
    }

    public bool StartsWithDotChar(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return false;
        }
        return str[0] == '.';
    }

    public bool StartsWithDotSpan(ReadOnlySpan<char> str)
    {
        if (str.IsEmpty)
        {
            return false;
        }
        return str[0] == '.';
    }
}
