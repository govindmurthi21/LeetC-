// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using LeetsMaybe;

Console.WriteLine($"Result for {1} : {string.Join(",", new MaxOddDecomp().Decompose(1))}");
Console.WriteLine($"Result for {2} : {string.Join(",", new MaxOddDecomp().Decompose(2))}");
Console.WriteLine($"Result for {3} : {string.Join(",", new MaxOddDecomp().Decompose(3))}");
Console.WriteLine($"Result for {4} : {string.Join(",", new MaxOddDecomp().Decompose(4))}");
Console.WriteLine($"Result for {5} : {string.Join(",", new MaxOddDecomp().Decompose(5))}");
Console.WriteLine($"Result for {6} : {string.Join(",", new MaxOddDecomp().Decompose(6))}");
Console.WriteLine($"Result for {7} : {string.Join(",", new MaxOddDecomp().Decompose(7))}");
Console.WriteLine($"Result for {8} : {string.Join(",", new MaxOddDecomp().Decompose(8))}");
Console.WriteLine($"Result for {9} : {string.Join(",", new MaxOddDecomp().Decompose(9))}");
Console.WriteLine($"Result for {10} : {string.Join(",", new MaxOddDecomp().Decompose(10))}");
Console.WriteLine($"Result for {11} : {string.Join(",", new MaxOddDecomp().Decompose(11))}");
Console.WriteLine($"Result for {12} : {string.Join(",", new MaxOddDecomp().Decompose(12))}");
Console.WriteLine($"Result for {13} : {string.Join(",", new MaxOddDecomp().Decompose(13))}");
Console.WriteLine($"Result for {14} : {string.Join(",", new MaxOddDecomp().Decompose(14))}");
Console.WriteLine($"Result for {23} : {string.Join(",", new MaxOddDecomp().Decompose(23))}");

 Console.WriteLine($"Result for {1} : {string.Join(",", new MaxOddDecomp().FasterDecompose(1))}");
 Console.WriteLine($"Result for {2} : {string.Join(",", new MaxOddDecomp().FasterDecompose(2))}");
 Console.WriteLine($"Result for {3} : {string.Join(",", new MaxOddDecomp().FasterDecompose(3))}");
Console.WriteLine($"Result for {4} : {string.Join(",", new MaxOddDecomp().FasterDecompose(4))}");
Console.WriteLine($"Result for {5} : {string.Join(",", new MaxOddDecomp().FasterDecompose(5))}");
Console.WriteLine($"Result for {6} : {string.Join(",", new MaxOddDecomp().FasterDecompose(6))}");
Console.WriteLine($"Result for {7} : {string.Join(",", new MaxOddDecomp().FasterDecompose(7))}");
Console.WriteLine($"Result for {8} : {string.Join(",", new MaxOddDecomp().FasterDecompose(8))}");
Console.WriteLine($"Result for {9} : {string.Join(",", new MaxOddDecomp().FasterDecompose(9))}");
Console.WriteLine($"Result for {10} : {string.Join(",", new MaxOddDecomp().FasterDecompose(10))}");
Console.WriteLine($"Result for {11} : {string.Join(",", new MaxOddDecomp().FasterDecompose(11))}");
Console.WriteLine($"Result for {12} : {string.Join(",", new MaxOddDecomp().FasterDecompose(12))}");
Console.WriteLine($"Result for {13} : {string.Join(",", new MaxOddDecomp().FasterDecompose(13))}");
Console.WriteLine($"Result for {14} : {string.Join(",", new MaxOddDecomp().FasterDecompose(14))}");
Console.WriteLine($"Result for {23} : {string.Join(",", new MaxOddDecomp().FasterDecompose(23))}");

BenchmarkRunner.Run<Benchy>();