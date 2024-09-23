using BenchmarkDotNet.Attributes;

namespace LeetsMaybe;

[MemoryDiagnoser(false)]
public class Benchy
{
    [Params(10_000)]
    public int N { get; set; }
    [Benchmark()]
    public void BenchyCheckDecompose()
    {
        new MaxOddDecomp().Decompose(this.N);
    }

    [Benchmark()]
    public void BenchyCheckDecomposeFasterDecompose()
    {
        new MaxOddDecomp().FasterDecompose(this.N);
    }
}