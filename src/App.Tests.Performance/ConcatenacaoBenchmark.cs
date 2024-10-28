using App.Core;
using BenchmarkDotNet.Attributes;

namespace App.Tests.Performance;

[MemoryDiagnoser]
[HtmlExporter]
public class ConcatenacaoBenchmark
{
    private readonly string[] _valores;

    public ConcatenacaoBenchmark()
    {
        _valores = new string[1000];
        for (var i = 0; i < _valores.Length; i++)
        {
            _valores[i] = "a"; // Cria um array com 1000 posições preenchidas com a letra "a"
        }
    }

    [Benchmark]
    public string ConcatenarComMais()
    {
        return Common.ConcatenarComMais(_valores);
    }

    [Benchmark]
    public string ConcatenarComStringBuilder()
    {
        return Common.ConcatenarComStringBuilder(_valores);
    }
}