using BenchmarkDotNet.Attributes;
using CheckPoint;

namespace Benchmarks;

[MemoryDiagnoser(false)]
public class CheckPointTests
{
    private static Task1 task = new Task1();
    private static int[] D = new[] { 5, 11, 1, 3 };
    private static int[] C = new[] { 6, 1, 3, 2 };
    private static int P = 7;
    [Benchmark] public void Task1_Linear() => task.Linear(D, C, P);
    //[Benchmark] public void Task1_LogLinear() => task.LogLinear(D, C, P);


    private static Task2 task2 = new Task2();
    private static int[] A2 = new[] { 7, 3, 1, 1, 4, 5, 4, 9 };
    //[Benchmark] public void Task2_Linear() => task2.Linear(A);
    [Benchmark] public void Task2_LogLinear() => task2.LogLinear(A2);


    private static Task3 task3 = new Task3();
    private static int[] A3 = new[] { 7, 3, 1, 1, 4, 5, 4, 9 };
    [Benchmark] public void Task3_Linear() => task3.Linear(A3);
    //[Benchmark] public void Task3_LogLinear() => task3.LogLinear(A3);
}
