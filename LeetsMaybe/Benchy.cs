using BenchmarkDotNet.Attributes;

namespace LeetsMaybe;

[MemoryDiagnoser(false)]
public class Benchy
{
    [Params(10_000, 14)]
    public int N { get; set; }
    [Benchmark()]
    public void BenchyCheck()
    {
        new MaxOddDecomp().Decompose(this.N);
    }
}